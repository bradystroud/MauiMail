namespace MauiMail.UI.Classes;

public class Message
{
    public string From { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }
    public bool Deleted { get; set; }
    public bool Flagged { get; set; }
}