using System;

namespace Pattern_Matching_Guide
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                Name = "Mike Ehrmantraut",
                Age = 45
            };

            Developer dev = new Developer
            {
                Name = "Walter White",
                Age = 27,
                Language = "JavaScript"
            };

            Engineer eng1 = new Engineer
            {
                Name = "Gus Fring",
                Age = 32,
                Leader = true
            };

            Engineer eng2 = new Engineer
            {
                Name = "Hector Salamanca",
                Age = 49,
                Leader = false
            };

            PrintPersonalInfo(emp);
            PrintPersonalInfo(dev);
            PrintPersonalInfo(eng1);
            PrintPersonalInfo(eng2);
            Console.ReadLine();
        }

        public static void PrintPersonalInfo(object person)
        {
            //switch (person)
            //{
            //    case Developer d:
            //        Console.WriteLine($"{d.Name} is a {d.Age}-year-old developer with {d.Language} skills");
            //        break;
            //    case Engineer e:
            //        Console.WriteLine($"{e.Name} is a {e.Age}-year-old engineer");
            //        break;
            //    case Employee em:
            //        Console.WriteLine($"{em.Name} is one of our employees");
            //        break;
            //}
            switch (person)
            {
                case Engineer e when e.Leader:
                    Console.WriteLine($"{e.Name} is currently leading a team");
                    break;
                case Engineer e when !e.Leader:
                    Console.WriteLine($"{e.Name} is not leading a team these days");
                    break;
            }

        }
    }
}
