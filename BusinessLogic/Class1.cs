namespace BusinessLogic
{
    public class FactorialService
    {
        public int CalcFact(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Must be a positive integer");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * CalcFact(n - 1);
        }
    }

}
