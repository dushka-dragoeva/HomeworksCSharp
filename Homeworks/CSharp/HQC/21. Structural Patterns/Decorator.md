# Decorator Pattern

## Описание
 * Този шаблон за дизайн ни позволява да добавяме допълнителна функционалност към даден базов клас по време на изпълнението на нашата програма. Като това се случва без да се променя поведението на други обекти от същия клас.
 *Освновният плюс е че ни предпазва от това да създаваме нови под-класове за да добавим нова функционалност. Като за всеки даден вариант и комбинация да имаме отделн клас (в примера по-надолу това щеше да заничи да имаме по 6 подкласа за всяко превозно средство, за да покрием възможността да се комбинират 3 екстри)   
 
## Цел
 * Добавя допълнителна функционалност на обектите динамично и е флексибилна алтернатива за заместване на множество под класове

## Известни употреби
 * In .NET: CryptoStream and GZipStream decorates Stream

## Implemntation
```
// base class
public abstract class VehicleComponent
    {
        public string Brand { get; set; }

        public decimal Price { get; set; }

        public abstract void DisplayInfo();

        public abstract void UpdatePrice(decimal updateCost);
    }

// Concrete Component клас. 
public class Car : VehicleComponent
    {
        public Car(string brand, decimal price)
        {
            this.Brand = brand;
            this.Price = price;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("{0} -----", this.GetType().Name);
            Console.WriteLine("Brand: {0}", this.Brand);
            Console.WriteLine("Price: {0}", this.Price);
        }

        public override void UpdatePrice(decimal updateCost)
        {
            this.Price += updateCost;
        }
    }

// базовият клас за всички декоратори
internal abstract class VehicleDecorator : VehicleComponent
    {
        protected VehicleDecorator(VehicleComponent vehicle)
        {
            this.Vehicle = vehicle;
        }

        protected VehicleComponent Vehicle { get; set; }

        public override void DisplayInfo()
        {
            this.Vehicle.DisplayInfo();
        }

        public override void UpdatePrice(decimal updateCost)
        {
            this.Vehicle.UpdatePrice(updateCost);
        }
    }


// добавя допълнителни функционалност или информация за подадения му обект
internal class V8EngineDecorator : VehicleDecorator
    {
         private const decimal V8EnginePrice = 27250;

         public V8EngineDecorator(VehicleComponent vehicle)
            : base(vehicle)
        {
            this.Vehicle.UpdatePrice(V8EnginePrice);            
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("++ Powerful V8 Engine Included");
        }

        public void DriveOnTrack()
        {
            Console.WriteLine("Driving around the local racing track");
        }
    }

// позволява ни лесно да комбинираме различните опции и лесно да изпозлваме нова функционалност. 

public class Client
    {
        public static void Main()
        {
            // Creating a car
            var basicCar = new Car("BMW", 85000);
            basicCar.DisplayInfo();
            LineSeparator();

            // Adding one option
            var updatedCar = new LeatherInteriorDecorator(basicCar);
            updatedCar.DisplayInfo();
            LineSeparator();

            // Adding all options
            var superCar = new V8EngineDecorator(new NavigationSystemDecorator(updatedCar));
            superCar.DisplayInfo();
            superCar.DriveOnTrack();
            LineSeparator();
        }

        private static void LineSeparator()
        {
            Console.WriteLine(new string('-', 50));
        }
    }
~~~

## Последствия
 *Decorator ни позволява да спазваме Open/Close принципа.
 *Предпазва от лавинообразно наразтване на класове


## Проблеми
 * Различните обекти нямат собствена индентичност, ковто води до лоша тестваемост
 * Наличието на множество сходни малки обекти води до трудна поддръжка
  
## UML  диаграма

![alt text](https://deansserver.co.uk/~dean/wp-content/uploads/2013/01/757px-Decorator_UML_class_diagram.svg_.png)
