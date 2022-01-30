using PizzaShop.Enums;
using PizzaShop.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShop.Domain.Models
{
     class PizzaDough : IProduct
     {
          public List<IIngredient> Ingredients { get; } = new();

          private readonly Storage _storage = Storage.Intance;

          public PizzaDough(bool isGlutenFree = false)
          {
               var doughType = isGlutenFree ? IngredientTypeEnum.GlutenFreeDough : IngredientTypeEnum.Dough;
               var dough = _storage.Ingredients.Single(ing => ing.Type == doughType);
               dough.Supply = 1;
               Ingredients.Add(dough);
          }

          public IProduct Clone()
          {
               return (IProduct)this.MemberwiseClone();
          }

          public double GetPrice()
          {
               return Ingredients.Sum(ing => ing.Price * ing.Supply);
          }

          public override string ToString()
          {
               var ingredientString = new StringBuilder();

               foreach (var ingredient in Ingredients)
               {
                    ingredientString.Append($" {ingredient.Type},");
               }

               return $"Pizza dough with{ingredientString}";
          }
     }
}
