# Flyweight Pattern

## Мотивация

 * Създаването на много обекти, които имат общи свойства или състояние използват много памет.
 * Всичко което е еднакво за обектите се намира в един общ клас който се преизползва.
 * За различните свойства се инициализират отделни обекти които преизползват общият клас.
 * Общата памет на обектите влиза като поле на конкретния обект.
 

## Цел

 * Споделане на общи ресурси с цел намаляване на използваната памет.

## Приложение
 * Използват се два обекта:
	** единият съдържа всички несподелени параметри
	** другият съдържа всички споделени параметри, които се подават на factory


## Известни употреби
 * string.Intern
 * графичното представяне на characters in word processor

## Имплментация 

```
using System;
using System.Collections;

  public class MainApp
  {
    public static void Main()
    { 
      // Create director and builders 
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products 
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user 
      Console.Read();
    }
  }

  // "Director" 
  class Director
  {
    // Builder uses a complex series of steps 
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder" 
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1" 
  class ConcreteBuilder1 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2" 
  class ConcreteBuilder2 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product" 
  class Product
  {
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
  ```

## Последствия
* Печели се добър пърформънс
* Намалява се използваната памет

## Сродни модели


## Проблеми
* При state - ако имаме клас, който искаме да преизползваме и той има state - в момента в който променим неговия state, това води до промени в state на всички класове които го преизползват.

## UML  диаграма

![alt text](http://www.coderanch.com/t/493146/a/1059/flywe050.gif)
