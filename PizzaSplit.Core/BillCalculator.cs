namespace PizzaSplit.Core
{
    public class BillCalculator
    {
        public double Calculate(int people, double amount, bool tips)
        {
            if (tips)
            {
                amount = amount * 1.10;
            }

            double result = amount / people;

            return result;
        }

    }
}
