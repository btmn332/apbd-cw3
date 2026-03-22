namespace apbd_cw3;

public class Użytkownik
{
    private static int IdCounter = 1;
    public int Id { get; private set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public TypUżytkownika typ { get; set; }
}


public enum TypUżytkownika
{
    Student,
    Pracownik
}