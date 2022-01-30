using PizzaShop.Interfaces;
using System;

namespace PizzaShop.Domain.PaymentStrategies
{
     class BitcoinPaymentStrategy : IPaymentStrategy
     {
          public void Pay(double amount)
          {
               Console.WriteLine("Please enter your account id");
               var accountId = Console.ReadLine();
               Console.WriteLine("Payment of " + amount + "$ is done using bitcoin account " + accountId);
          }
     }
}
