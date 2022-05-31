using System;

namespace Vote
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
<<<<<<< HEAD
            person.Age = 18;
=======
            person.Age = 32;

            Console.WriteLine($"Mag deze persoon stemmen? {person.CanVote}");

            Console.ReadKey();
>>>>>>> 9da578ea3a78511a17cb9ac3ace8a91ad1269637
        }
    }
}
