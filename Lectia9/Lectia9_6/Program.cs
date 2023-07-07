class Pr
{
    static void Main()
    {
        try
        {
            DeschideFisier();
            ProceseazaInformatia();
        }
        catch (Exception)
        {
            Console.WriteLine("Procesara a rezultat intr-o exceptie. Ne pare rau :(");
        }
        finally
        {
            InchideFisier();
        }
    }

    private static void InchideFisier()
    {
        throw new NotImplementedException();
    }

    private static void ProceseazaInformatia()
    {
        throw new NotImplementedException();
    }

    private static void DeschideFisier()
    {
        throw new NotImplementedException();
    }
}