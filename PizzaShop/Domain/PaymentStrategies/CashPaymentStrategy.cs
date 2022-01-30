using PizzaShop.Interfaces;
using System;

namespace PizzaShop.Domain.PaymentStrategies
{
     class CashPaymentStrategy : IPaymentStrategy
     {
          public void Pay(double amount)
          {
               Console.WriteLine("The amount of" + amount + "$ will be given to the courier upon receipt of the order.");
          }
     }
}
