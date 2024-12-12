
namespace EDA.Practice;

// This Notification class which will be published by the publisher
internal class NotificationEvent
{
    public string NotificationMessage { get; private set; }

    public DateTime NotificationDate { get; private set; }

    public NotificationEvent(DateTime dateTime, string message)
    {
        NotificationDate = dateTime;
        NotificationMessage = message;
    }

}
