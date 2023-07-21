class Animal
{
    public string Nume { get; set; }

    public virtual void AfisareDetalii()
    {
        Console.WriteLine(Nume);
    }
}

class Mamifer : Animal
{
    public string CuloareBlana { get; set; }

    public override void AfisareDetalii()
    {
        base.AfisareDetalii();
        Console.WriteLine(CuloareBlana);
    }
}

class Pasare : Animal
{
    public string TipZbor { get; set; }

    public override void AfisareDetalii()
    {
        base.AfisareDetalii();
        Console.WriteLine(TipZbor);
    }
}

class Papagal : Pasare
{
    public string Vocabular { get; set; }

    public override void AfisareDetalii()
    {
        base.AfisareDetalii();
        Console.WriteLine(Vocabular);
    }
}

