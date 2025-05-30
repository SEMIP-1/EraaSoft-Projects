namespace FantacyFootball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Player player1 = new Player();
            player1.Name = "John Doe";
            Player player2 = new Player();
            player2.Name = "Jane Smith";
            Console.WriteLine(player1.Over());
            Console.WriteLine(player2.Passing(player1));
            Console.WriteLine(player1.Shooting());

        }
    }
}
