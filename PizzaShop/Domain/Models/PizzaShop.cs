using PizzaShop.Domain.Builder;
using PizzaShop.Domain.Services;
using PizzaShop.Enums;
using PizzaShop.Interfaces;
using System.Collections.Generic;

namespace PizzaShop.Domain.Models
{
     class PizzaShop : IPizzaShop
     {
          private Menu _menu;
          private Storage _storage;
          private ProxyDeliveryService _deliveryService;
          public PizzaShop()
          {
               _storage = Storage.Intance;

               _storage.Ingredients.AddRange(new List<IIngredient>() {
                    new Ingredient(IngredientTypeEnum.Capsicum, 5, 1),
                    new Ingredient(IngredientTypeEnum.Cheese, 10, 1),
                    new Ingredient(IngredientTypeEnum.Olive, 7, 1),
                    new Ingredient(IngredientTypeEnum.Dough, 9, 5),
                    new Ingredient(IngredientTypeEnum.GlutenFreeDough, 12, 2),
                    new Ingredient(IngredientTypeEnum.Salami, 10, 3)
               });

               _menu = Menu.Instance;

               var availableProducts = new List<IProduct>() {
                    new PizzaBuilder().AddDough().AddCheese().AddSalami(5).AddOlive().AddCapsicum(4).Bake(),
                    new PizzaBuilder().AddDough(true).AddCheese().AddOlive().AddSalami(5).Bake(),
                    new PizzaBuilder().AddDough().AddCheese().AddCapsicum(3).AddSalami(2).Bake(),
                    new PizzaDough(),
                    new PizzaDough(true)
               };

               foreach(var product in availableProducts)
               {
                    _menu.Items.Add(new MenuItem(_menu.Items.Count, product));
               }

               _deliveryService = new();
          }

          public List<MenuItem> GetMenuItems()
          {
               return _menu.Items;
          }

          public IProduct OrderMenuItem(int id)
          {
               var orderedItem = _menu.Items.Find(item => item.Id == id);
               if(orderedItem == null)
               {
                    return null;
               }

               return orderedItem.Item.Clone();
          }

          public void GetDelivery(List<IProduct> order)
          {
               _deliveryService.Deliver(order);
          }
     }
}
