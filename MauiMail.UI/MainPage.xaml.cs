using MauiMail.UI.Classes;

namespace MauiMail.UI;

public partial class MainPage : ContentPage
{
    public IList<Message> Emails { get; set; } = new List<Message>
    {
        new Message
        {
            From = "John Doe",
            Subject = "Hello World 1",
            Body = "This is the first test message from today",
            Date = DateTime.Today,
        },
        new Message
        {
            From = "John Doe",
            Subject = "Hello World 2",
            Body = "This is the second test message from today",
            Date = DateTime.Today,
        },
        new Message
        {
            From = "John Doe",
            Subject = "Hello World 3",
            Body = "This is the third test message from today",
            Date = DateTime.Today,
        },
    };

    public IList<Message> VisibleEmails => Emails.Where(e => !e.Deleted).ToList();

    public int MessagesCount => Emails.Count;

    public MainPage()
    {
        InitializeComponent();
        
        BindingContext = this;
    }
}