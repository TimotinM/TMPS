# Topic: Structural Design Patterns

### Author: Timotin Mihai

---

## Objectives :

**1. Study the Structural Design Patterns**

**2. Implement them in real projects**

## Theory :

Design patterns are a group of predefined solutions that help in solving different common programming problems. Mainly Design Patterns are divided into 3 categories: Creational, Structural and Behavioral.
Structural design patterns are concerned with how classes and objects can be composed, to form larger structures.

- Adapter Pattern
  Adapting an interface into another according to client expectation.

- Bridge Pattern
  Separating abstraction (interface) from implementation.

- Composite Pattern
  Allowing clients to operate on hierarchy of objects.

- Decorator Pattern
  Adding functionality to an object dynamically.

- Facade Pattern
  Providing an interface to a set of interfaces.

- Flyweight Pattern
  Reusing an object by sharing it.

- Proxy Pattern
  Representing another object.

## Implementation :

In this project I've used 3 structural design patterns:Bridge, Proxy and Facade.<br/>
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes. In this case the Facade class is represented by the PizzaShop class. Client communicates with the Facade class using the IPizzaShop interface. Using this pattern, client doesn't need to know anything about the PizzaShop system except the methods which are exposed by the PizzaShop class. In this way, Facade Pattern simplifies the interaction with our system.<br/>

```
    interface IPizzaShop
     {
          List<MenuItem> GetMenuItems();
          IProduct OrderMenuItem(int id);
          void GetDelivery(List<IProduct> order);
     }
```

Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other. In this case Bridge design pattern is represented by the IProduct and IIngredient relationships. In this way we completely separated the this set of closely related classes into 2 hierarchies.

```
    interface IIngredient
    {
        IngredientTypeEnum Type { get; }
        float Price { get; }
        int Supply { get; set; }
    }

    interface IProduct
    {
        List<IIngredient> Ingredients { get; }
        public double GetPrice();
        public IProduct Clone();
    }
```

Using this interfaces we can create several concrete implementations, like Cake and PizzaDough which extend IProduct or Ingredient which extend IIngredient.<br/>
Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object. In the case of our system the proxy is used to control access to the delivery services

```
  class ProxyDeliveryService
     {
          IDeliveryService _carDeliveryService = new CarDeliveryService();
          IDeliveryService _bikeDeliveryService = new BikeDeliveryService();

          public void Deliver(List<IProduct> products)
          {
               if(products.Count > 5)
               {
                    _carDeliveryService.Deliver(products);
                    return;
               }
               _bikeDeliveryService.Deliver(products);
          }
     }
```
