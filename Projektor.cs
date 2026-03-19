namespace apbd_cw3;

public class Projektor : Sprzęt
{
    public string Rozdzielczość { get; set; }
    public bool Bezprzewodowy { get; set; }

    public Projektor(string nazwa, string model, string rozdzielczość, bool bezprzewodowy) : base(nazwa, model)
    {
        Rozdzielczość = rozdzielczość;
        Bezprzewodowy = bezprzewodowy;
    }
}