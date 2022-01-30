# Topic: Creational Design Patterns

### Author: Timotin Mihai

---

## Objectives :

**1. Study the Creational Design Patterns**

**2. Implement them in real projects**

## Theory :

Design patterns are a group of predefined solutions that help in solving different common programming problems. Mainly Design Patterns are divided into 3 categories: Creational, Structural and Behavioral.
The Creational design patterns deal with object creation. The most common creational design patterns are listed bellow.

- Singleton
- Builder
- Prototype
- Factory Method
- Abstract Factory

## Implementation :

In this project I've used 3 creational design patterns:Builder, Prototype and Singleton.<br />
Singleton Design Pattern is used to ensure that you have a single instance of a specific object in the entire app. In this project, the Menu and Storage class are both singeltons, because a pizza shop can have only one menu and one storage. For the Menu class I implemented the Singleton pattern using static constructor implementation and for the Storage I've used Lazy implementation. Both of them are thread safe.<br />

```
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
```

```
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
```

The Builder design patter was used for the Pizza creation because a Pizza can have a long list of optional ingredients and setting all of them in the constructor as nullable will make code to look messy and hard to read. For implementing the Builder pattern I created a class **PizzaBuilder** which provides all necessary methods for creating a large number of different pizza. There are different implementations of the builder, but the one which is used in this project is allowing chaining builder methods because each method inside the Builder class returns "this" (builder instance), except the **Bake()** method which returns the concrete built object.<br />

```
    interface IPizzaBuilder
     {
          IPizzaBuilder AddDough(bool isGlutenFree = false);
          IPizzaBuilder AddCheese();
          IPizzaBuilder AddCapsicum(int units);
          IPizzaBuilder AddOlive();
          IPizzaBuilder AddSalami(int units);
          Pizza Bake();
     }
```

And the last Creational Pattern implemented in this project is Prototype. It was implemented using the IProduct interface which has the Clone method and each product implements it. So when a client wants to order a product he doesn't care about the concrete implementation, it uses the IProduct interface.

```
    public IProduct OrderMenuItem(int id)
          {
               var orderedItem = _menu.Items.Find(item => item.Id == id);
               if(orderedItem == null)
               {
                    return null;
               }

               return orderedItem.Item.Clone();
          }
```
