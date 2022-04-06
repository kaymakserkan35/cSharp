using System;

namespace boxing_unboxing
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Teacher : Person
    {
        public string Branch { get; set; }
        public Teacher(string name, int age, string branch) : base(name, age)
        {
            Branch = branch;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("dilek", 25, "English");
            Person pt = (Person)teacher;
            // Teacher teacher1 = new Person("dilek", 25);
            // Teacher teacher1 = (Teacher)new Person("dilek", 25);
            Person person = new Person("dilek", 25);
            Person teacher1 = new Teacher("dilek", 25, "English");
            Object obj = new Teacher("dilek", 25, "English");


            Method(teacher);
            Method(pt);
            Method(person);
            Method(teacher1);

            Method2(pt);
            Method2(teacher);
            Method2(person);
            Method2(teacher1);
            Method2(obj);

        }


        static void Method(Person p) { Console.WriteLine(p.Name); }
        static void Method2(Object o) { Console.WriteLine("deneme"); }

    }
}
