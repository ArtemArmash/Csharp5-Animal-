Cat cat = new Cat(1, "#5232", 5.3, "#7182853", "Gray", "Fat", false);
cat.PrintInfo();
cat.AddGraft();
cat.PrintInfo();
cat.Sterilization();

abstract class Animal
{
    protected int age;
    protected string? id;
    protected double weight;
    protected string? id_client;

    public Animal(int age, string? id, double weight, string? id_client)
    {

        this.age = age;
        this.id = id;
        this.weight = weight;
        this.id_client = id;

    }

    public abstract void PrintInfo();
    public abstract bool AddGraft();
    public abstract bool Sterilization();

}


class Cat : Animal
{
    private string? color;
    private string? wool;
    private bool graft;

    public Cat(int age, string? id, double weight, string? id_client, string? color, string? wool, bool graft) :
        base(age, id, weight, id_client)
    {
        this.color = color;
        this.wool = wool;
        this.graft = graft;
    }

    public override bool AddGraft()
    {
        if (!graft)
        {
            Console.WriteLine("Graft added successfully.");
            graft = true;
            return true;
        }
        else
        {
            Console.WriteLine("Graft already added.");
            return false;
        }
    }
    public override bool Sterilization()
    {
        Console.WriteLine("Cat sterilized.");
        return true;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Information for Cat: \nAge: {age}\nId: {id}\nWeight: {weight}\nID Client: {id_client}\nColor: {color}\n" +
            $"Wool: {wool}\nGraft? : {graft}");
    }

}