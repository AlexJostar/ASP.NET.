var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Company comp1 = new Company("Arasaka", 01, "123 Main Street", 43, "Corporation");
app.MapGet("/info", () => comp1.Info());
app.MapGet("/", () => comp1.RandomNumber());

app.Run();

class Company
{
    public string Name { get; set; }
    public int Idbranch { get; set; }
    public string Adress { get; set; }
    public float Workers { get; set; }
    public string Type { get; set; }

    public Company(string name, int id, string adress, float workers, string type)
    {
        this.Name = name;
        this.Idbranch = id;
        this.Adress = adress;
        this.Workers = workers;
        this.Type = type;
    }

    public string Info()
    {
        return ("Company name: " + this.Name + "\nId Company: " + this.Idbranch + "\nAdress: " + this.Adress + "\nWorkers amount: " + this.Workers + "\nType: " + this.Type);
 
    }

    public int RandomNumber()
    {
        return (new Random()).Next(0, 101);
    }

}
