namespace apbd_cw3;

public class Aparat : Sprzęt
{
    public string Rozdzielczość {get; set;}
    public string Rodzaj {get; set;}

    public Aparat(string nazwa, string model, string rozdzielczość, string rodzaj) : base(nazwa, model)
    {
        Rozdzielczość = rozdzielczość;
        Rodzaj = rodzaj;
    }
}