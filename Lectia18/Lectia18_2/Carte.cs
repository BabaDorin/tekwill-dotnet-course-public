class Carte : Produs
{
    public string Autor { get; set; }

    public override void Afisare()
    {
        Console.WriteLine($"Carte: {Nume}, Autor: {Autor}, Pret: {Pret} lei");
    }
}
