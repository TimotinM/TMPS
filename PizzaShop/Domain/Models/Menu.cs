using System.Collections.Generic;

namespace PizzaShop.Domain.Models
{
     sealed class Menu
     {
          public List<MenuItem> Items { get; set; } = new();

          private static readonly Menu _menuInstance = new();
          private Menu() { }

          public static Menu Instance
          {
               get
               {
                    return _menuInstance;
               }
          }
     }
}
