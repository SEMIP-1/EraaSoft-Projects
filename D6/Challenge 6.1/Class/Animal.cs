using System;
namespace Challenge_6._1
{
    public class Animal
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public virtual string AnimalSound()
        {
           return "The animal makes a sound";
        }
    }
    public class Pig : Animal
    {
        public string? Size { get; set; }
        public override string AnimalSound()
        {
            return "The pig says: wee wee";
        }
    }
    public class Dog : Animal
    {
        public string? Size { get; set; }
        public override string AnimalSound()
        {
            return "The dog says: bow wow";
        }
    }
}
