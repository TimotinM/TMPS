using System.Collections.Generic;

namespace PizzaShop.Interfaces
{
     interface IProduct
     {
          List<IIngredient> Ingredients { get; }
          public double GetPrice();
          public IProduct Clone();
     }
}
