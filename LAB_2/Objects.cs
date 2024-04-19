namespace LAB_2;

public class Disc
{
    private string Capacity;
    private string Model;
    public double Price { get;}

    public Disc(string capacity, string model, double price)
    {
        Capacity = capacity;
        Model = model;
        Price = price;
    }

    public String GetName()
    {
        return Model + " " + Capacity;
    }
}