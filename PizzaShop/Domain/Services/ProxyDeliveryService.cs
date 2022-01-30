using PizzaShop.Interfaces;
using System.Collections.Generic;

namespace PizzaShop.Domain.Services
{
     class ProxyDeliveryService
     {
          IDeliveryService _carDeliveryService = new CarDeliveryService();
          IDeliveryService _bikeDeliveryService = new BikeDeliveryService();

          public void Deliver(List<IProduct> products)
          {
               if(products.Count > 5)
               {
                    _carDeliveryService.Deliver(products);
                    return;
               }
               _bikeDeliveryService.Deliver(products);           
          }
     }
}
