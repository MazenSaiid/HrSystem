using HR.OOP.Syste_;

namespace HR.OOP.System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new SalariedEmployee();
            employee.SetName("Mazen", "Saiid");
            employee.SetBirthDate(new DateOnly(1997, 6, 1));
            PrintPersonDetails(employee);

            Console.WriteLine("----------------");

            var applicant = new Applicant();
            applicant.SetName("Malek", "Mohamed");
            applicant.SetBirthDate(new DateOnly(1995, 12, 22));
            PrintPersonDetails(applicant);

            Console.WriteLine("----------------");

            var salariedEmployee = new SalariedEmployee();
            salariedEmployee.SetName("Mariam", "Aly");
            salariedEmployee.SetBirthDate(new DateOnly(1997, 10, 18));
            salariedEmployee.BasicSalary = 3000;
            salariedEmployee.Housing = 2000;
            salariedEmployee.Transportation = 1000;
            Console.WriteLine($"Salary of SalariedEmployee is {salariedEmployee.GetSalary()}");
            Console.WriteLine($"Salary of SalariedEmployee with 10% TaxPercentage is {salariedEmployee.GetSalary(10)}");
            Console.WriteLine($"Salary of SalariedEmployee with 2000 bonus is {salariedEmployee.GetSalary(10,2000)}");

            Console.WriteLine("----------------");

            var hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.SetName("Adham", "Mahmoud");
            hourlyEmployee.SetBirthDate(new DateOnly(1994, 4, 20));
            hourlyEmployee.TotalHours = 100;
            hourlyEmployee.HourRate = 50;
            Console.WriteLine($"Salary of HourlyEmployee is {hourlyEmployee.GetSalary()}");
            Console.WriteLine("----------------");

            var intern = new Intern();
            intern.SetName("Mai", "Ahmed");
            intern.SetBirthDate(new DateOnly(1999,2, 27));
            Console.WriteLine($"Salary of Intern is {intern.GetSalary()}");

            Console.WriteLine("----------------");

            var notifier = new Notifier("mail@example.com", 80, "noreply@example.com", "Abc123#$");
            var paySlipGenerator = new PaySlipGenerator(notifier);
            paySlipGenerator.Generate(salariedEmployee);
            paySlipGenerator.Generate(hourlyEmployee);
            paySlipGenerator.Generate(intern);

        }
        static void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"Full name \t {person.FirstName} {person.LastName} ");
            Console.WriteLine($"BirthDte \t {person.BirthDate}");
        }
    }
}