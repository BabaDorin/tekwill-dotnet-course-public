class Program
{
    struct Employee
    {
        public string name;
        public double salary;
    }

    static void Main()
    {

        Employee[] employees = new Employee[]
        {
            new Employee
            {
                name = "Andrei",
                salary = 2455
            },
            new Employee
            {
                name = "Abraham",
                salary = 5000
            }
        };

        // Caculate the sum of all salaries
        double sum = CalculateSum(employees);

        // Calcualte average
        double average = CalculateAverageSalary(employees);
        
        // Sort employees by salary
        SortArrayWithBubbleSort(employees);

        employees = employees.OrderBy(emp => emp.salary).ToArray();
    }

    private static double CalculateSum(Employee[] employees)
    {
        double sum = 0;
        foreach (var employee in employees)
        {
            sum += employee.salary;
        }

        var sumLinq = employees.Sum(emp => emp.salary);

        return sum;
    }

    private static double CalculateAverageSalary(Employee[] employees)
    {
        double sum = 0;
        foreach (var employee in employees)
        {
            sum += employee.salary;
        }

        var average = sum / employees.Length;

        var averageLinq = employees.Average(x => x.salary);

        return average;
    }

    private static void SortArrayWithBubbleSort(Employee[] employees)
    {
        int n = employees.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (employees[j].salary > employees[j + 1].salary)
                {
                    var aux = employees[j].salary;
                    employees[j] = employees[j + 1];
                    employees[j + 1] = employees[j];
                }
            }
        }
    }
}