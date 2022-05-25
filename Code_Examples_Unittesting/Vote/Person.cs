using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    public class Person
    {
        public int Age { get; set; }
        public bool CanVote { get => Age >= 18;}
    }
} 
