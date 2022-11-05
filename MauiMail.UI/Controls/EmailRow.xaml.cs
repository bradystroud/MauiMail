using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiMail.UI.Classes;

namespace MauiMail.UI.Controls;

public partial class EmailRow : ContentView
{
    public static readonly BindableProperty EmailProperty = BindableProperty.Create("Email", typeof(Mail),
        typeof(EmailRow), null, BindingMode.OneWay, null, OnEmailChanged);
    
    private static void OnEmailChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var email = (Mail) newValue;
        var emailRow = (EmailRow) bindable;
        
        if (email == null) return;

#if MACCATALYST || WINDOWS
        var desktopView = new DesktopEmailRow();
        desktopView.BindingContext = email;
        emailRow.Content = desktopView;
#else
        var mobileEmailRow = new MobileEmailRow();
        mobileEmailRow.BindingContext = email;
        emailRow.Content = mobileEmailRow;
#endif
    }

    public EmailRow()
    {
        InitializeComponent();
    }
}