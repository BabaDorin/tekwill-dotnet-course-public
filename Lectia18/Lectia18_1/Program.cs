using Lectia18_1;

class Program
{
    static void Main()
    {
        var shoppingCart = new ShoppingCart();

        shoppingCart.AdaugaProduse("mere");
        shoppingCart.AdaugaProduse("mandarine");
        shoppingCart.AdaugaProduse("pere");
        shoppingCart.AdaugaProduse("detergenti");

        var produseSpreAdaugare = new List<string>
        {
            "bauturi",
            "paine"
        };

        shoppingCart.AdaugaProduse(produseSpreAdaugare);
        shoppingCart.AdaugaProduse("mere", "rosii", "vinete");

        shoppingCart.AdaugaProduse("mere", "pere");

        Console.WriteLine();
    }
}