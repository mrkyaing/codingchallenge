﻿namespace EDA.Practice;

internal class Publisher
{

    //publishers name
    public string PublisherName { get; private set; }

    //publishers notification interval
    public int NotificationInterval { get; private set; }

    // declare a delegate function
    public delegate void Notify(Publisher p, NotificationEvent e);

    // declare an event variable of the delegate function
    public event Notify OnPublish;

    // class constructor
    public Publisher(string publisherName, int notificationInterval)
    {
        PublisherName = publisherName;
        NotificationInterval = notificationInterval;
    }

    //publish function publishes a Notification Event
    public void Publish()
    {
        while (true)
        {

            // fire event after certain interval
            Thread.Sleep(NotificationInterval);

            if (OnPublish != null)
            {
                NotificationEvent notificationEvent = new NotificationEvent(DateTime.Now, "New Notification Arrived from");
                OnPublish(this, notificationEvent);
            }
            Thread.Yield();
        }
    }
}
