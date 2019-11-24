namespace Salary_App_Assignment
{
    public class Calcurate
    {
        public int employeId;
        public string employeName;
        public string employePosition;
        public string employeGender;
        
        public double CalculateMonthlySalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
            return salary;
        }
        public double CalculateHourlySalary(double rate, double hour)
        {
            double salary;
            salary=(rate*hour)-((((rate*hour)*5)/100)+(((rate*hour)*3)/100));
            return salary;
        }

        public double CalculateOneTimeSalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - ((grossSalary * 30) / 100);
            return salary;
        }
    }
}