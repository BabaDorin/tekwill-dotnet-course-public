class Program
{
    static void Main()
    {
        Stack<char> paranteze = new Stack<char>();

        var expresie = "((3 + 4))) + ((3 + 1) * 3)";

        foreach(var caracter in expresie)
        {
            if (caracter == '(')
            {
                paranteze.Push(caracter);
            }

            if (caracter == ')')
            {
                var ultimaParantezaDeschisa = paranteze.Pop();
            }
        }

        if (paranteze.Count == 0)
        {
            Console.WriteLine("Expresie valida");
        }
        else
        {
            Console.WriteLine("Expresie invalida");
        }
    }
}