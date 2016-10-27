using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_zadatak4
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public string Jmbag { get; set; }
            public Gender Gender { get; set; }

            public Student(string name, string jmbag)
            {

                Name = name;
                Jmbag = jmbag;
            }
        }

        public enum Gender
        {
            Male, Female
        }


        static void Main(string[] args)
        {
            

            var list = new List<Student>()
            {
                    new Student (" Ivan ", jmbag :" 001234567 ") ,
                    new Student (" Ivan ", jmbag :" 001234567 ")
            };
            // 2 :(

            foreach(Student i in list)
            {
                Console.WriteLine(i.Name + ' ' + i.Jmbag);
            }
            var distinctStudents = (from l in list
                                    select l.Jmbag).Distinct().Count();
            Console.WriteLine(distinctStudents);
            Console.Read();
            

            
        }


    }
}
