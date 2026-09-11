namespace PizzaSplit.Core
{
    public static class BillCalculator
    {
        public static double Calculate(int people, double amount, bool tips)
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
