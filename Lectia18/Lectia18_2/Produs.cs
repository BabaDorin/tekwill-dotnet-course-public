class Produs
{
    public string Nume { get; set; }
    public double Pret { get; set; }

    public virtual void Afisare()
    {
        Console.WriteLine($"Produs: {Nume}, Pret: {Pret} lei");
    }
}
