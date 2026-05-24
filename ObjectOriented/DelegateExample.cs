using System;

namespace ObjectOriented1
{
    //public delegate int ArithmeticOperation(int x, int y);

    public delegate void NotifyUser(string message);

    internal class DelegateExample


    {
        public void run()
        {
            NotifyUser notify = Delegate.SendEmail;
            notify += Delegate.SendSMS;
            notify += Delegate.SendPushNotification;

            notify -= Delegate.SendSMS;

            notify("Hello, this is a notification!");

            //event halepachi invoke garna milcha
        }
            

        public  void run1()
        {
            publisher pub = new publisher();
            pub.myDelegate += Delegate.SendEmail;
            pub.myDelegate += Delegate.SendSMS;
            pub.Announcement();
        }
        
        //ArithmeticOperation add = ArithmeticClass.Add;
        //ArithmeticOperation sub = ArithmeticClass.sub;
        //ArithmeticOperation mul = ArithmeticClass.mul;
        //add(10, 20);
        //sub(10, 20);
        //mul(10, 20);
        //}
        //    public void run()
        //    {
        //        ArithmeticOperation del1 = new ArithmeticOperation(ArithmeticClass.Add);
        //        ArithmeticOperation del2 = ArithmeticClass.sub;
        //        ArithmeticOperation del3 = ArithmeticClass.Add;

        //      //MulticastDelegate         
        //        del1+= ArithmeticClass.sub;
        //        del1+= ArithmeticClass.mul;
        //        del1-= ArithmeticClass.sub;
        //        int sum = del1(10, 20);
        //        int sub = del2(10, 20);
        //        int sum1= del3.Invoke(10, 20);

        //        Console.WriteLine($"Sum: {sum}, Sub: {sub}");

        //        //ArithmeticOperation  add = ArithmeticClass.Add;
        //        //ArithmeticOperation sub = ArithmeticClass.sub;
        //        //ArithmeticOperation mul = ArithmeticClass.mul;
        //        //add(10, 20);
        //        //sub(10, 20);
        //        //mul(10, 20);
        //    }
        //}

        //public class ArithmeticClass
        //{
        // public static  int Add(int a, int b)
        //    {

        //        var output = a + b;
        //        Console.WriteLine($"Add Result: {output}");
        //        return output;

        //    }   

        //    public static int sub(int a, int b)
        //    {
        //        var output  = a - b;
        //        Console.WriteLine($"Sub Result: {output}");
        //        return output;
        //    }

        //    public static int mul(int a, int b)
        //    {
        //        var output = a * b;
        //        Console.WriteLine($"Mul Result: {output}");
        //        return output;
        //    }   


        public class Delegate
        {
            public static void SendEmail(string message)
            {
                Console.WriteLine($"Email sent with message: {message}");
            }   

            public static void SendSMS(string message)
            {
                Console.WriteLine($"SMS sent with message: {message}");
            }

            public static void SendPushNotification(string message)
            {
                Console.WriteLine($"Push notification sent with message: {message}");
            }
        }

        class publisher
        {
            public event  NotifyUser myDelegate;

            public void Announcement()
            {
                myDelegate("Hello");
            }
        } 


    }
}