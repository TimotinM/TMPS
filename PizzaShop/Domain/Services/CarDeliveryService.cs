using PizzaShop.Interfaces;
using System.Collections.Generic;

namespace PizzaShop.Domain.Services
{
     class CarDeliveryService : IDeliveryService
     {
          public float Price { get; } = 10;
          public float MaxNumberOfUnits { get; } = 100;

          public void Deliver(List<IProduct> products)
          {
               System.Console.WriteLine("The order will be delivered to you by car.");
          }
     }
}
