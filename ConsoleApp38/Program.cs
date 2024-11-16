using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Student
    {
        public string Name;
        public int id;
        public int mark;


    }
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number of Students :");
            Console.WriteLine("must be fom 5 to 10");
            int c = int.Parse(Console.ReadLine());
            if (c >= 5 && c <= 10)
            {
                List<Student> students = new List<Student>();
                for (int i = 0; i < c; i++)
                {
                    Student student = new Student();
                    Console.WriteLine("enter the name of the student "  );
                    string Name = Console.ReadLine();

                    Console.WriteLine("enter the id of the student " );
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the mark of the student "  );
                    int mark = int.Parse(Console.ReadLine());
                    student.Name = Name;
                    student.mark = mark;
                    student.id = id;
                    students.Add(student);


                }
                bool  found = false;
                Console.WriteLine("the student how pass is :");

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].mark > 49)
                    {
                        found = true;
                        Console.WriteLine(" the name student : " + students[i].Name);
                        Console.WriteLine("the id of student :" + students[i].id);
                    }
                }
                if(!found)
                 Console.WriteLine("no student pass !!");
                
            }
            else
             Console.WriteLine("the number of student must be from 5 to 10 !!");
            Console.ReadLine();
            





        }

    }
}
