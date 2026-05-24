using System;

namespace ObjectOriented
{
    
    public delegate void NotifyUser(string message);

    internal class MulticastDelegateExample
    {
        public void run()
        {
            
            NotifyUser notify = new NotifyUser(Notifier.SendEmail);
            notify += Notifier.SendSMS;
            notify += Notifier.SendPushNotification;

            notify("Your order has been shipped!");
        }
    }

    class Notifier
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine("Email: " + message);
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS: " + message);
        }

        public static void SendPushNotification(string message)
        {
            Console.WriteLine("Push Notification: " + message);
        }
    }
}


//Multicast delegate is a delegate that can hold references to
//multiple methods and invoke them one by one with a single call.
