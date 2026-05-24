using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class OperatorOverLoadingExample
    {
        //   public void run()
        //    {
        //        var science = new Marks(85);
        //        var math = new Marks(90);
        //        var total = science + math;
        //    }
        //}

        //class Marks
        //{
        //    public double Score;
        //    public Marks(double score)
        //    {
        //        Score = score;
        //    }
        //    public static double operator + (Marks marks1, Marks marks2)
        //    {
        //        return   marks1.Score + marks2.Score;
        //    }
        //    public static double operator - (Marks marks1, Marks marks2)
        //    {
        //        return marks1.Score - marks2.Score;
        //    }


        class Money
        {
            public decimal Amount;
            public decimal Currency;
            public Money(decimal amount, decimal currency)
            {
                Amount = amount;
                Currency = currency;
            }


            public static Money operator +(Money money1, Money money2)
            {
                if(money1.Currency == money2.Currency && money2.Amount > money1.Amount)
                {
                    decimal output = money1.Amount + money2.Amount;
                    return new Money(output, money1.Currency);
                }
                else
                {
                    return money1;
                }
                

            }
            public static Money operator -(Money money1, Money money2)
            {
                if (money1.Currency == money2.Currency && money2.Amount > money1.Amount)
                {
                    decimal output = money2.Amount - money1.Amount;
                    return new Money(output, money1.Currency);
                }
                else
                {
                    return money1;
                }
            }
        }
    }

}