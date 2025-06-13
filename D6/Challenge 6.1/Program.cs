namespace Challenge_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Animal myAnimal = new Animal();     // Create a Animal object
            Animal myPig = new Pig();           // Create a Pig object
            Animal myDog = new Dog();           // Create a Dog object

            Console.WriteLine(myAnimal.AnimalSound()); // The animal makes a sound
            Console.WriteLine(myPig.AnimalSound());    // The pig says: wee wee
            Console.WriteLine(myDog.AnimalSound());    // The dog says: bow wow

        }
    }
}
