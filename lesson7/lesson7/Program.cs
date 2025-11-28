namespace lesson7;


class Program
{
    static public void Main(string[] args)
    {
        // Cat cat = new Cat(21, "");


        // cat.SendAnimalVoice();
        // cat.SendAge();

    }
}

interface PersonInterface
{
    // public int age;

    public void ShowPerson();
}

interface DogInterface
{
    public void ShowDog();
}

class NewClass: PersonInterface, DogInterface
{
    void PersonInterface.ShowPerson()
    {
        System.Console.WriteLine("f");
    }

    void DogInterface.ShowDog()
    {
        System.Console.WriteLine("d");
    }
}

abstract class AbstractPerson
{
    public int age = 100;


    public abstract void ShowAge();

    public void Print()
    {
        System.Console.WriteLine(123);
    }
}




// class Animal
// {
//     protected int age;

//     public Animal()
//     {
//         System.Console.WriteLine("я животное");
//     }

//     protected Animal(int age)
//     {
//         System.Console.WriteLine(age);
//     }

//     public virtual void SendAnimalVoice()
//     {
//         System.Console.WriteLine("voice");
//     }

//     public void SendAge()
//     {
//         System.Console.WriteLine(age);
//     }
// }


// class Cat : Animal
// {

//     string food;

//     public Cat(int age, string food) : base(age)
//     {
//         System.Console.WriteLine("Я кот");
//         this.food = food;
//         base.age = age;
//     }

//     public override void SendAnimalVoice()
//     {
//         System.Console.WriteLine("мяу");
//     }

// }

// class Dog
// {
//     public void fff()
//     {
//         System.Console.WriteLine("ffffff");
//     }
// }

// class Lion : Cat
// {
//     public Lion(int age, string food) : base(age, food)
//     {
//         System.Console.WriteLine("fffff");
//     }
// }