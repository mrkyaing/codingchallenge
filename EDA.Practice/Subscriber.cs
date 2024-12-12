namespace EDA.Practice;

internal class Subscriber
{
    public string SubscriberName { get; private set; }

    public Subscriber(string subscriberName)
    {
        SubscriberName = subscriberName;
    }

    // This function subscribe to the event if it is raised by the Publisher
    public void Subscribe(Publisher publisher)
    {
        //https://www.tutorialsteacher.com/csharp/csharp-event
        // register OnNotificationReceived with publisher event
        publisher.OnPublish += OnNotificationReceived;  // multicast delegate
    }

    // This function unsubscribe from the event if it is raised by the Publisher
    public void Unsubscribe(Publisher p)
    {
        // unregister OnNotificationReceived from publisher
        p.OnPublish -= OnNotificationReceived;  // multicast delegate
    }

    // It get executed when the event published by the Publisher
    protected virtual void OnNotificationReceived(Publisher publisher, NotificationEvent notiEvent)
    {
        Console.WriteLine("Hey " + SubscriberName + "," + notiEvent.NotificationMessage + " " + publisher.PublisherName + " at " + notiEvent.NotificationDate);
    }
}
