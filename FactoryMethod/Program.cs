Transport transport = new MechanicalTransport("Velomesto");
Delivery delivery1 = transport.CreateDelivery();

transport = new ElectricTransport("Volt Race");
Delivery delivery2 = transport.CreateDelivery();

Console.ReadLine();


abstract class Transport
{
    public string Speed { get; set; }

    public Transport(string s)
    {
        Speed = s;
    }
    // фабричный метод
    abstract public Delivery CreateDelivery();
}

class MechanicalTransport : Transport
{
    public MechanicalTransport(string n) : base(n)
    { }

    public override Delivery CreateDelivery()
    {
        return new BicycleDelivery();
    }
}

class ElectricTransport : Transport
{
    public ElectricTransport(string n) : base(n)
    { }

    public override Delivery CreateDelivery()
    {
        return new ElectricScooterDelivery();
    }
}

abstract class Delivery
{ }

class BicycleDelivery : Delivery
{
    public BicycleDelivery()
    {
        Console.WriteLine("Заказ был доставлен на велосипеде");
    }
}
class ElectricScooterDelivery : Delivery
{
    public ElectricScooterDelivery()
    {
        Console.WriteLine("Заказ был доставлен на электросамокате");
    }
}