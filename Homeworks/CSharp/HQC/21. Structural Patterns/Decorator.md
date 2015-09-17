# Composite Pattern

## ��������
 * ���� ������ �� ������ �� ��������� �� �������� ������������ �������������� ��� ����� ����� ���� �� ����� �� ������������ �� ������ ��������. ���� ���� �� ������ ��� �� �� ������� ����������� �� ����� ������ �� ����� ����.

 *���������� ���� � �� �� ��������� �� ���� �� ��������� ���� ���-������� �� �� ������� ���� ��������������. ���� �� ����� ����� ������� � ���������� �� ����� ������ ���� (� ������� ��-������ ���� ���� �� ������ �� ����� �� 6 �������� �� ����� �������� ��������, �� �� ������� ������������ �� �� ���������� 3 ������)   

 
## ���
 * ������ ������������ �������������� �� �������� ��������� � � ����������� ����������� �� ���������� �� ��������� ��� �������


## �������� ��������
 * In .NET: CryptoStream and GZipStream decorates Stream

## Implemntation
������ ���� �� ���� ��� ���� �� ������������ ������ �������� ��������

![alt text](diagrams/decorator.png)

###### public abstract class VehicleComponent � ���� � ������� ���� ����� � �� ������������ ������, ���� � �� ���� ����� �� ����� "����������". ��� ������ ������� ���������� �������������� ���� �� ���������� ��������� 
~~~c#
public abstract class VehicleComponent
    {
        public string Brand { get; set; }

        public decimal Price { get; set; }

        public abstract void DisplayInfo();

        public abstract void UpdatePrice(decimal updateCost);
    }
~~~

###### public class Car � �.���. Concrete Component ����. ��� �� ���� ��������� �� ���������� �� �� �� ���� �������� ���� ������������� ��� �� ���� �����������. 
~~~c#
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
~~~

###### internal abstract class VehicleDecorator - ���� � �������� ���� �� ������ ����������. ����� ��������� VehicleComponent, �� �� ���� �������� ���������� �� �� ������� ������ Concrete Components (� ������ Car ��� SUV). ������� �������� ����������� ����� ������ VehicleComponent, ����� �� ��������� �� �������� ���� ����� ���������� ��� �������� ���������� �� ������� ����. 
~~~c#
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
~~~

###### internal class V8EngineDecorator - ������ ������������ �������������� ��� ���������� �� ��������� �� �����
~~~c#
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
~~~

###### ���������� �� ������ �� ������� - ��������� �� ����� �� ����������� ���������� ����� � ����� �� ���������� ���� ��������������. 
~~~c#
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

## �����������
 *Decorator �� ��������� �� �������� Open/Close ��������.
 *��������� �� ������������� ���������� �� �������


## ��������
 * ���������� ������ ����� ��������� ������������, ����� ���� �� ���� �����������
 * ��������� �� ��������� ������ ����� ������ ���� �� ������ ���������
  
## UML  ��������

![alt text](http://www.coderanch.com/t/493146/a/1059/flywe050.gif)
