namespace apbd_cw3;

public class Laptop : Sprzęt
{
    public double RozmiarEkranu { get; set; }
    public string SystemOperacyjny { get; set; }

    public Laptop(string nazwa, string model, double rozmiarEkranu, string systemOperacyjny) : base(nazwa, model)
    {
        RozmiarEkranu = rozmiarEkranu;
        SystemOperacyjny = systemOperacyjny;
    }
}