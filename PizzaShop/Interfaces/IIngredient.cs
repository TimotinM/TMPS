using PizzaShop.Enums;

namespace PizzaShop.Interfaces
{
     interface IIngredient
     {
          IngredientTypeEnum Type { get; }
          float Price { get; }
          int Supply { get; set; }
     }
}
