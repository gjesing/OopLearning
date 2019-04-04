using OopLearning.BL;
using OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;

namespace OopLearning.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "Knud Erik",
                Cpr = "0311891515"
            };
            Employee e = new Employee()
            {
                Name = "Daniel Valsby-Koch",
                Cpr = "0311890101",
                Initials = "DAVA"
            };
            Student s = new Student()
            {
                Name = "Maren Gjesing Laursen",
                Cpr = "2205010202",
                UniLogin = "mare0231"
            };
            List<Person> people = new List<Person>()
            {
                p,e,s
            };
            foreach (Person person in people)
            {
                Console.WriteLine(person.CreateIdentifier());
            }
            DocumentFileInfo document = new DocumentFileInfo("dokument", 1, DateTime.Now);
            ImageFileInfo image = new ImageFileInfo("billede", 1, DateTime.Now, 500, 500);
            VideoFileInfo video = new VideoFileInfo("video", 1, DateTime.Now, 500, 500, 200);
            Console.WriteLine(document);
            Console.WriteLine(image);
            Console.WriteLine(video);
            Console.ReadLine();
        }
    }
}
