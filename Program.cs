using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }



    internal class Program
    {


        static void Main(string[] args)
        {
            var pr1 = new Person();
            pr1.Name = "Ali";
            var pr2 = new Person();
            pr2.Name = "Ahmad";
            var pr3 = new Person();
            pr3.Name = "Resul";
            var pr4 = new Person();
            pr4.Name = "Mahmud";
            var pr5 = new Person();
            pr5.Name = "Gulshen";
            var pr6 = new Person();
            pr6.Name = "Nargiz";
            var pr7 = new Person();
            pr7.Name = "Heyder";
            var pr8 = new Person();
            pr8.Name = "Kenan";
            var pr9 = new Person();
            pr9.Name = "Lale";
            var pr10 = new Person();
            pr10.Name = "Nezrin";


            List<Person> Personlist = new List<Person>
            {
                new Person {Name=pr10.Name},
                new Person {Name=pr9.Name},
                new Person {Name=pr8.Name},
                new Person {Name=pr7.Name},
                new Person {Name=pr6.Name},
                new Person {Name=pr5.Name},
                new Person {Name=pr4.Name},
                new Person {Name=pr3.Name},
                new Person {Name=pr2.Name},
                new Person {Name=pr1.Name},
            };

            Console.WriteLine($"Enter name: ");
            string axtarish = Console.ReadLine();


            foreach (var item in Personlist)
            {
                if (axtarish == item.Name)
                {
                    Console.WriteLine("Found!");
                    return;
                }

            }
            Console.WriteLine("Notfound");
        }



    }
}