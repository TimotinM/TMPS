using PizzaShop.Domain.Models;
using PizzaShop.Enums;
using PizzaShop.Interfaces;
using System;
using System.Linq;

namespace PizzaShop.Domain.Builder
{
     class PizzaBuilder : IPizzaBuilder
     {
          private readonly Pizza _cake = new();
          private readonly Storage _storage = Storage.Intance;
 
          public IPizzaBuilder AddCapsicum(int units = 1)
          {
               var capsicums = _storage.Ingredients.Single(ing => ing.Type == IngredientTypeEnum.Capsicum);
               capsicums.Supply = units;
               _cake.Ingredients.Add(capsicums);
               return this;
          }

          public IPizzaBuilder AddCheese()
          {
               var cheese = _storage.Ingredients.Single(ing => ing.Type == IngredientTypeEnum.Cheese);
               cheese.Supply = 1;
               _cake.Ingredients.Add(cheese);
               return this;
          }

          public IPizzaBuilder AddDough(bool isGlutenFree = false)
          {
               var pizzaDoughType = isGlutenFree ? IngredientTypeEnum.GlutenFreeDough : IngredientTypeEnum.Dough;
               var pizzaDough = _storage.Ingredients.Single(ing => ing.Type == pizzaDoughType);
               pizzaDough.Supply = 1;
               _cake.Ingredients.Add(pizzaDough);
               return this;
          }

          public IPizzaBuilder AddOlive()
          {
               var olives = _storage.Ingredients.Single(ing => ing.Type == IngredientTypeEnum.Olive);
               olives.Supply = 1;
               _cake.Ingredients.Add(olives);
               return this;
          }

          public IPizzaBuilder AddSalami(int units)
          {
               var salami = _storage.Ingredients.Single(ing => ing.Type == IngredientTypeEnum.Salami);
               salami.Supply = units;
               _cake.Ingredients.Add(salami);
               return this;
          }

          public IPizzaBuilder AddSecreteIngredient()
          {
               var secretIngredient = new SecretIngredient(new Random().Next(50), 1);
               _cake.Ingredients.Add(secretIngredient);
               return this;
          }

          public Pizza Bake()
          {
               foreach(var ingredient in _cake.Ingredients)
               {
                    var storageIngredient = _storage.Ingredients.Single(ing => ing.Type == ingredient.Type);

               }
               return _cake;
          }
     }
}
