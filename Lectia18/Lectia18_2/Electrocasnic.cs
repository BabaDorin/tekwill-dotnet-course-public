class Electrocasnic : Produs
{
    public string Producator { get; set; }

    public override void Afisare()
    {
        Console.WriteLine($"Electrocasnic: {Nume}, Producator: {Producator}, Pret: {Pret} lei");
    }
}
