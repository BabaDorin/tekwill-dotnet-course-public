using System;


class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee { Name = "John", Salary = 50000 };

        PayCalculator payCalculator = new PayCalculator();
        payCalculator.CalculatePay(employee);

        DatabaseSaver databaseSaver = new DatabaseSaver();
        databaseSaver.SaveEmployee(employee);
    }

    class PaymentManager
    {
        public void ProcessPayment(string payment)
        {
            ValidatePayment(payment);
            // Verifica daca payment engine e activ / enabled
            // Transmite request catre payment engine
            // Primeste raspuns => valideaza rapunsu
            // ..
            // ..
        }

        private void ValidatePayment(string payment)
        {
            // Valideaza payment
        }
    }
}
