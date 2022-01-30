using PizzaShop.Domain.Models;

namespace PizzaShop.Interfaces
{
     interface IPizzaBuilder
     {
          IPizzaBuilder AddDough(bool isGlutenFree = false);
          IPizzaBuilder AddCheese();
          IPizzaBuilder AddCapsicum(int units);
          IPizzaBuilder AddOlive();
          IPizzaBuilder AddSalami(int units);
          Pizza Bake();
     }
}
