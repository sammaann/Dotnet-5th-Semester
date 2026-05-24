using System;

namespace ObjectOriented
{
    public delegate void SubscriberNotification(string message);

    internal class YoutubeTask
    {
        public void Run()
        {
            YoutubeChannel myChannel = new YoutubeChannel("Tech Channel");

            Subscriber sub1 = new Subscriber("Sangam");
            Subscriber sub2 = new Subscriber("Ramey");

            myChannel.notifier += sub1.ReceiveNotification;
            myChannel.notifier += sub2.ReceiveNotification;

            myChannel.UploadVideo("Learn C# Events");

            myChannel.notifier -= sub1.ReceiveNotification;

            myChannel.UploadVideo("Advanced C# Delegates");
        }
    }

    class YoutubeChannel
    {
        public string channelName;
        public event SubscriberNotification? notifier;  

        public YoutubeChannel(string name)
        {
            channelName = name;
        }

        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"\n[Channel Update] {channelName} just uploaded: {videoTitle}");
            notifier?.Invoke($"New video '{videoTitle}' is out on {channelName}!");
        }
    }

    class Subscriber
    
    {
        public string userName;

        public Subscriber(string name)
        {
            userName = name;
        }

        public void ReceiveNotification(string notification)
        {
            Console.WriteLine($"{userName} received notification: {notification}");
        }
    }
}