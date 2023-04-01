Transport transport = new MechanicalTransport("Velomesto");
Delivery delivery1 = transport.CreateDelivery();

transport = new ElectricTransport("Volt Race");
Delivery delivery2 = transport.CreateDelivery();

Console.ReadLine();


abstract class Delivery
{
    public int Time { get; set; }

    public Delivery(int t)
    {
        Time = t;
    }
    // фабричный метод
    abstract public Transport CreateTransport();
}

class BicycleDelivery : Delivery
{
    public BicycleDelivery(int t) : base(t)
    { }

    public override Transport CreateTransport()
    {
        return new Bicycle();
    }
}

class ElectricScooterDelivery : Delivery
{
    public ElectricScooterDelivery(int t) : base(t)
    { }

    public override Transport CreateTransport()
    {
        return new ElectricScooter();
    }
}

abstract class Transport
{ }

class Bicycle : Transport
{
    public Bicycle()
    {
        Console.WriteLine("Заказ был доставлен на велосипеде");
    }
}
class ElectricScooter : Transport
{
    public ElectricScooter()
    {
        Console.WriteLine("Заказ был доставлен на электросамокате");
    }
}