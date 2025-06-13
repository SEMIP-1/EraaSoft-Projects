namespace Challenge_6._2
{
    internal class Program
    {
        class ClsCalculator
        {
            public static bool AreEqual<T>( T val1, T val2)
            {
                if (val1.Equals(val2)) 
                    return true;
                return false;
            }
        }
        public class Account
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public Account(string name, double balance)
            {
                Name = name;
                Balance = balance;
            }
            public override bool Equals(object? obj)
            {
                if (obj is Account account)
                {
                    return this.Name == account.Name && Balance == account.Balance;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            bool IsEqual = ClsCalculator.AreEqual<Account>(new Account("Mohamed", 2000), new Account("Mohamed", 2000));

            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
        }
    }
}
