using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;
    public double Bonus;

    public void CalculateBonus(double bonusPercentage, out int id, out string name, out double salary, out double bonus)
    {
        Console.Write("Enter ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = double.Parse(Console.ReadLine());

        bonus = salary * bonusPercentage;
    }
}

class Program1
{
    static void Main()
    {
        Employee[] employees = new Employee[5];

        double bonusPercentage = 0.1;
        for (int i = 0; i < employees.Length; i++)
        {
            int id;
            string name;
            double salary;
            double bonus;

            Console.WriteLine($"Enter details for Employee {i + 1}:");
            employees[i] = new Employee();
            employees[i].CalculateBonus(bonusPercentage, out id, out name, out salary, out bonus);

            employees[i].Id = id;
            employees[i].Name = name;
            employees[i].Salary = salary;
            employees[i].Bonus = bonus;
        }

        Console.WriteLine("\nEmployee Details with Bonus:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Bonus: {employee.Bonus}");
        }
        Console.ReadLine();
    }
  
}
