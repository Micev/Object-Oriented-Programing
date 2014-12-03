using System;
using System.Collections.Generic;


namespace School
{
    class TestStudents
    {
        public static void Main()
        {
            Student gosho = new Student("Gosho", 1);
            Student ivan = new Student("Ivan", 3);

            Disciplines matematica = new Disciplines("Matematica",32, new List<Student>{ gosho, ivan });
            Disciplines risuvane = new Disciplines("Risuvane",22, new List<Student>{ gosho, ivan });

            Teacher mariq = new Teacher("Mariq", new List<Disciplines>{ matematica, risuvane});
            Teacher misho = new Teacher("Misho", new List<Disciplines>{ matematica});


            Classes a = new Classes("A", new List<Teacher> { misho },"tova e nai dobriq klas");
            Classes b = new Classes("B", new List<Teacher> { misho , mariq});

            
        }
    }
}
