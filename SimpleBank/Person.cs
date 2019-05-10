using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class Person
    {
        private int Id {get; set; }
        private string Name { get; set; }
        private string Address { get; set; }

        public Person()
        {

        }

        public Person(int id,string name,string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Id= {Id} name= {Name} address= {Address}";
        }

    }
}
