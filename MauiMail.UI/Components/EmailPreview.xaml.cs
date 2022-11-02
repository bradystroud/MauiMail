using System.Windows.Input;
using MauiMail.UI.Classes;

namespace MauiMail.UI.Components;

public partial class EmailPreview : ViewCell
{
    public static readonly BindableProperty EmailProperty =
        BindableProperty.Create("Email", typeof(Message), typeof(EmailPreview),
            propertyChanged: EmailPropertyChanged);

    private static void EmailPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var email = (Message) newValue;
        var preview = (EmailPreview) bindable;

        if (email == null) return;

        preview.BindingContext = email;
    }

    public ICommand DeleteClickedCommand { private set; get; }

    public EmailPreview()
    {
        InitializeComponent();
    }

    private void Delete_OnClicked(object sender, EventArgs e)
    {
        ((Message) BindingContext).Deleted = true;
    }

    private void Flagged_OnClicked(object sender, EventArgs e)
    {
        ((Message) BindingContext).Flagged = true;
    }
}