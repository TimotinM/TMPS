using PizzaShop.Interfaces;
using System;
using System.Collections.Generic;

namespace PizzaShop.Domain.Models
{
     sealed class Storage
     {
          private static readonly Lazy<Storage> _storageIntance = new(() => new Storage());
          private Storage() { }
          private static List<IIngredient> _ingredients = new();
          public List<IIngredient> Ingredients
          {
               get => _ingredients;
               set => _ingredients = value;
          }
          public static Storage Intance
          {
               get => _storageIntance.Value;
          }
     }
}
