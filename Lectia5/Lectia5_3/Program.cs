class Program
{
    enum ZileleSaptamanii
    {
        Luni,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica
    }

    enum Gender
    {
        Masculin,
        Feminin
    }

    enum AnulDeStudii
    {
        I,
        II,
        III,
        IV,
        V,
        VI
    }

    static void Main()
    {
        int azi = (int)ZileleSaptamanii.Marti;

        AnulDeStudii anulDeStudii = AnulDeStudii.I;
    }
}