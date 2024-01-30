public class Truck
{
    public Truck(string brand, string model, int weight) 
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
   
    public string Brand {  get; set; }
    public string Model { get; set; }

    public int Weight { get; set; }
}

public class Cars
{

    public Cars(string brand, string model, int horsepower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsepower;
    }

    public string Brand { set; get; }

    public string Model { get; set; }

    public int HorsePower {  get; set; }

}

public class Catalogue
{
    string Collection { get; set; }

}


