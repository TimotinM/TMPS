using PizzaShop.Interfaces;
using System.Collections.Generic;

namespace PizzaShop.Domain.Services
{
     class BikeDeliveryService : IDeliveryService
     {
          public float Price { get; } = 5;
          public float MaxNumberOfUnits { get; } = 5;

          public void Deliver(List<IProduct> products)
          {
               System.Console.WriteLine("The order will be delivered to you by bike.");
          }
     }
}
