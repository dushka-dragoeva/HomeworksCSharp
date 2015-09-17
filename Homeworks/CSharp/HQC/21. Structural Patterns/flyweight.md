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
	** другият съдържа всички споделени параметри, които се подават на factory, което flyweight pattern използва вътрешно


## Известни употреби
 * string.Intern
 * графичното представяне на characters in word processor

## Имплментация 

```
// Create an Abstract Flyweight class Soldier:
public abstract class Soldier
{        
          public WeaponType Weapon{get;set;}
          public abstract void RenderSoldier(string StrPriName, string Color);
}



// Create a Concrete Flyweight classes GunSoldier and SwordSoldier as:

public class GunSoldier:Soldier
{
          public GunSoldier()
          {
                    this.Weapon = WeaponType.Gun;
          }
          public override void RenderSoldier(string StrPriName, string Color)
          {                 
                    HttpContext.Current.Response.Write("Gun Character " + StrPriName + " Rendered with "+Color+" Color");                      
          }
}
 
public class SwordSoldier:Soldier
{
          public SwordSoldier()
          {
                    this.Weapon = WeaponType.Sword;
          }
          public override void RenderSoldier(string StrPriName, string Color)
          {
                    HttpContext.Current.Response.Write("Sword Character " + StrPriName + " Rendered with " + Color + " Color");                             
          }
}



// Create a Flyweight Facttory SoldierFactory:
 
public class SoldierFactory
{
          Dictionary<string, Soldier> SoldierCollection;
          public SoldierFactory()
          {
                    SoldierCollection = new Dictionary<string, Soldier>();
          }
          public Soldier GetSoldier(string SoldierIndex)
          {                 
                    if(!SoldierCollection.ContainsKey(SoldierIndex))
                    {
                              HttpContext.Current.Response.Write("Objet created - ");
                              switch(SoldierIndex)
                              {
                                        case "0":
                                        SoldierCollection.Add(SoldierIndex, new GunSoldier());
                                        break;
                                        case "1":
                                        SoldierCollection.Add(SoldierIndex, new SwordSoldier());
                                        break;
                              }
                    }
                    else
                    {
                              HttpContext.Current.Response.Write("Objet reused - ");
                    }
                    return SoldierCollection[SoldierIndex];
          }
}



// client code:
 
this.CreateSoldier(DdlCharacterType1, TxtCharacterName1, TxtColor1);
Response.Write("<Br>");
this.CreateSoldier(DdlCharacterType2, TxtCharacterName2, TxtColor2);
Response.Write("<Br>");
this.CreateSoldier(DdlCharacterType3, TxtCharacterName3, TxtColor3);
.
.
.
private void CreateSoldier(DropDownList DdlCharacterType, TextBox TxtCharacterName, TextBox TxtColor)
{
          Soldier soldier = factory.GetSoldier(DdlCharacterType.SelectedValue);
          soldier.RenderSoldier(TxtCharacterName.Text,TxtColor.Text);
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
