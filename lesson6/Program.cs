namespace lesson6;

class Program
{
    static void Main(string[] args)
    {
        Car Marcedes = new Car("Marcedes", 2000, 200);
        Car BMW = new Car("BMW", 1970, 120);
        Car AUDI = new Car("AUDI", 2015, 300);

        Marcedes.carInfo();
        BMW.carInfo();
        AUDI.carInfo();

        Marcedes.PrintModel();
        BMW.PrintModel(true);
    }
}



class Car
{
    
    private int yearOfExit;

    public string Model { get; set; }

    public int MaxSpeed { get; set; }

    public int YearOfExit
    {
        get
        {
            return yearOfExit;
        }
        set
        {
            if (value < 1985)
            {
                yearOfExit = 0;
            }
            else
            {
                yearOfExit = value;
            }
        }
    }

    public Car(string model, int yearOfExit, int maxSpeed)
    {
        Model = model;
        YearOfExit = yearOfExit;
        MaxSpeed = maxSpeed;
    }

    public void PrintModel()
    {
        System.Console.WriteLine(Model);
    }

    public void PrintModel(bool isTrue)
    {
        if (isTrue)
        {
            System.Console.WriteLine(MaxSpeed);
            System.Console.WriteLine(Model);
        }
    }

    public void carInfo()
    {
        System.Console.WriteLine($"Model: {Model} \nYear of exit: {YearOfExit} \nMax speed {MaxSpeed}");
        if (YearOfExit == 0)
        {
            System.Console.WriteLine("Машина застаріла");
        }
        System.Console.WriteLine("=========================================");
    }
}


class SportCar: Car
{

    public bool Spoiler { get; set; }


    
    public SportCar(string model, int yearOfExit, int maxSpeed, bool spoiler): Car(string model, int yearOfExit, int maxSpeed)
    {
        Spoiler = spoiler;
    }
}