using MauiMail.UI.Classes;

namespace MauiMail.UI;

public partial class MainPage : ContentPage
{
    public IList<Mail> Emails { get; set; } = new List<Mail>
    {
        new Mail
        {
            From = "Jack",
            Subject = "Hello 1",
            Body = "How are you?",
            Date = DateTime.Now
        },
        new Mail
        {
            From = "Jim",
            Subject = "Hello 2",
            Body = "How are you?",
            Date = DateTime.Now
        },
        new Mail
        {
            From = "Jill",
            Subject = "Hello 3",
            Body = "How are you?",
            Date = DateTime.Now
        },
        new Mail
        {
            From = "Jane",
            Subject = "Hello 4",
            Body = "How are you?",
            Date = DateTime.Now
        },
    };
    
    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }
}