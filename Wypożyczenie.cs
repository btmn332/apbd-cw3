namespace apbd_cw3;

public class Wypożyczenie
{
    public DateOnly DataWypożyczenia { get; set; }
    public DateOnly TerminZwrotu { get; set; }
    public DateOnly DataZwrotu { get; set; }
    public Użytkownik Użytkownik { get; set; }
    public Sprzęt Sprzęt { get; set; }
    public int Opłaty { get; set; }

    public Wypożyczenie(DateOnly dataWypożyczenia, DateOnly terminZwrotu, Użytkownik użytkownik, Sprzęt sprzęt)
    {
        DataWypożyczenia = dataWypożyczenia;
        TerminZwrotu = terminZwrotu;
        Użytkownik = użytkownik;
        Sprzęt = sprzęt;
    }
}