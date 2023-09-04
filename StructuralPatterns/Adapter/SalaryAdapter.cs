namespace DP.StructuralPatterns.Adapter;
public class SalaryAdapter:SalaryCalculator
{
    private Employee _emp;
    public double CalcSalary(MachineOperator oper)
    {
        _emp = new Employee(){
            Name = oper.Name,
            BasicSalary = oper.BasicSalary
        };
        return base.CalcSalary(_emp);
    }
}