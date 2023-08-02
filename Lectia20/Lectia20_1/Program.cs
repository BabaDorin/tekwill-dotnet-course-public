using Lectia20_1;
using Lectia20_1.Entities;

class Program
{
    //    Dezvoltați o aplicație pentru gestionarea unui magazin online.
    //    Utilizati genericele pentru a dezvolta o clasa Database generica,
    //    pentru manipularea urmatoarelor informatii:
    //      -	Produse
    //      -	Clienti
    //      -	Comenzi
    static void Main()
    {
        var productDb = new Database<Product>();
        var clientDb = new Database<Client>();
        var orderDb = new Database<Order>();

        var productId = Guid.NewGuid();

        var product = new Product
        {
            Id = productId,
            Name = "Laptop",
            Price = 200
        };

        productDb.Add(product);
        var foundProduct = productDb.Get(productId);

        var productUpdated = new Product
        {
            Id = productId,
            Name = "Laptop",
            Price = 240
        };

        productDb.Update(productUpdated);
        productDb.Delete(productId);
    }
}