namespace DP.StructuralPatterns.Adapter;

public class SalaryCalculator
{
    public double CalcSalary(Employee emp){
        return emp.BasicSalary*1.5;
    }
}