using Lectia14_homework_2;

class Program
{
    static void Main()
    {
        var persoana = new Persoana()
        {
            identificator = "200873394293",
            tip = TipPersoana.Fizica
        };

        var contBancar = new ContBancar(persoana, "203004404", Moneda.MDL, "1111");

        contBancar.Alimentare(10000);
        contBancar.Extragere(2000);
        contBancar.Alimentare(10000);
        contBancar.Extragere(5000);
        contBancar.Alimentare(3002);
        contBancar.Extragere(234);

        contBancar.Extragere(209009000);
    }
}