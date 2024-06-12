using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP;

public enum SalaryType
{
    Manager = 1,
    Developer = 2,
    Tester = 3,
    JuniorDeveloper = 4
}

public interface ISalaryCalculate
{
    decimal Calculate(decimal price);
}

internal class ManagerSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal price)
    {
        return price * 1.2m;
    }
}

internal class DeveloperSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal price)
    {
        return price * 1.1m;
    }
}

internal class TesterSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal price)
    {
        return price * 1.05m;
    }
}




public class SalaryCalculateService
{
    public decimal Calculate(decimal price, ISalaryCalculate salaryCalculateService)
    {
        return salaryCalculateService.Calculate(price);
    }
    public decimal Calculate(decimal price, SalaryType salaryType)
    {
        decimal salary = 0;
        switch (salaryType)
        {
            case SalaryType.Manager:
                salary = price + (price * 1.2m);
                break;
            case SalaryType.Developer:
                salary = price + (price * 1.1m);
                break;
            case SalaryType.Tester:
                salary = price + (price * 1.05m);
                break;
            case SalaryType.JuniorDeveloper:
                salary = price + (price * 1.03m);
                break;
            default:
                break;
        }
        return salary;
    }
}


