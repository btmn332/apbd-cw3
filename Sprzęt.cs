namespace apbd_cw3;

public abstract class Sprzęt
{
    static int IdCounter = 1;
    public int Id { get; protected set; }
    public string Nazwa { get; set; }
    public bool Dostępny { get; set; }
    public string Model { get; set; }

    public Sprzęt(string nazwa, string model)
    {
        Id  = IdCounter++;
        Nazwa = nazwa;
        Model = model;
        Dostępny = true;
    }
}