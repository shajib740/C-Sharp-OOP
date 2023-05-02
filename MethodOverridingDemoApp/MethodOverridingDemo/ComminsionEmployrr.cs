namespace MethodOverridingDemo
{
    public class ComminsionEmployrr : EmployeeModel
    {
        public  decimal CommisionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {

            decimal initialPay = base.GetPaycheckAmount(hoursWorked);

            return initialPay + CommisionAmount;
        }
    }
}
