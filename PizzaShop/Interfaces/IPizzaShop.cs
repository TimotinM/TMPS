using PizzaShop.Domain.Models;
using System.Collections.Generic;

namespace PizzaShop.Interfaces
{
     interface IPizzaShop
     {
          List<MenuItem> GetMenuItems();
          IProduct OrderMenuItem(int id);
          void GetDelivery(List<IProduct> order);
     }
}
