using System;

namespace Vote
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 32;

            Console.WriteLine($"Mag deze persoon stemmen? {person.CanVote}");

            Console.ReadKey();
        }
    }
}
