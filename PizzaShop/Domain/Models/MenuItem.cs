using PizzaShop.Interfaces;

namespace PizzaShop.Domain.Models
{
     class MenuItem
     {
          public int Id { get; }
          public IProduct Item { get; }
          public MenuItem(int id, IProduct product)
          {
               Id = id;
               Item = product;
          }

          public override string ToString()
          {
               return $"Id = {Id}\n" +
                      $"Item = {Item}\n" +
                      $"Price = {Item.GetPrice()}\n";
          }
     }
}
