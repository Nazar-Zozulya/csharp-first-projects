namespace lesson4;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero();

        Hero hero2 = new Hero();

        hero.get("123");

        hero2.get("2");


        System.Console.WriteLine(hero.set());
        System.Console.WriteLine(hero2.set());

        hero.returnName(hero2);

        hero.attack();

        hero2.attack();
    } 
}
class Hero
{
    public int health;

    public Hero(string name)
    {
        this.name = name;
        System.Console.WriteLine("Я создался: " + this.name);

        
    }
    
    public Hero()
    {

    }

    public void returnName(Hero obj)
    {
        string a = obj.set();

        System.Console.WriteLine(a + " вивевся 2 обьект");

    }

    public void get(string name)
    {
        this.name = name;
    }

    public string set()
    {
        return name;
    }

    int damage = 2;

    int armor = 4;

    public string name = "";

    public void attack()
    {
        System.Console.WriteLine($"{name} атакує ворога");
    }
}