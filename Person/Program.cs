using System;
using Person;


namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David", 47, 70.99f, 219.5f);
            David.name = "David";
            David.age = 47;
            David.height = 70.999f;
            David.weight = 219.55f;
            David.comparethis = Person.compare.weight;

            Person Joe = new Person();
            Person John = new Person();
            Person Amanda = new Person();
            Person Carrie = new Person();
            Person Sherry = new Person();
            Person Shelly = new Person();
            Person Carol = new Person();
            Person Gene = new Person();

            Joe.name = "Joe";
            Joe.age = 55;
            Joe.height = 57.88f;
            Joe.weight = 244;
            Joe.comparethis = Person.compare.weight;

            John.name = "John";
            John.age = 60;
            John.height = 68.88f;
            John.weight = 199;
            John.comparethis = Person.compare.weight;

            Amanda.name = "Amanda";
            Amanda.age = 28;
            Amanda.height = 60.22f;
            Amanda.weight = 120;
            Amanda.comparethis = Person.compare.weight;

            Carrie.name = "Carrie";
            Carrie.age = 32;
            Carrie.height = 59.99f;
            Carrie.weight = 110;
            Carrie.comparethis = Person.compare.weight;

            Sherry.name = "Sherry";
            Sherry.age = 23;
            Sherry.height = 53.33f;
            Sherry.weight = 109;
            Sherry.comparethis = Person.compare.weight;

            Carol.name = "Carol";
            Carol.age = 55;
            Carol.height = 45;
            Carol.weight = 99;
            Carol.comparethis = Person.compare.weight;

            Gene.name = "Gene";
            Gene.age = 28;
            Gene.height = 52.22f;
            Gene.weight = 115;
            Gene.comparethis = Person.compare.weight;

            Person[] people = new Person[8] { David, Joe, John, Amanda, Carrie, Sherry, Carol, Gene };

            Array.Sort(people);

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadKey();
        }
    }
}


       