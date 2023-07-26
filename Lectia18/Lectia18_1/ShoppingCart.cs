namespace Lectia18_1
{
    internal class ShoppingCart
    {
        private List<string> produse;

        public ShoppingCart()
        {
            produse = new List<string>();
        }

        public void AdaugaProduse(string produsSpreAdaugare, int nr)
        {
            produse.Add(produsSpreAdaugare);
        }

        public void AdaugaProduse(string produs1, string produs2)
        {
            produse.Add(produs1);
        }
        public void AdaugaProduse(string produs2, string produs1)
        {
            produse.Add(produs1);
            produse.Add(produs2);
        }

        public void AdaugaProduse(List<string> produseSpreAdaugare)
        {
            produse.AddRange(produseSpreAdaugare);
        }

        public void AdaugaProduse(params string[] produseSpreAdaugare)
        {
            produse.AddRange(produseSpreAdaugare);
        }
    }
}
