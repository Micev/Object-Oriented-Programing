using System;
using System.Collections.Generic;
using System.Linq;


namespace HumanStudentWorker
{
    class Test
    {
        public static void Main()
        {

            Student gosho = new Student("Georgi", "Ivanov", "3542145");
            Student dimitar = new Student("Dimitar", "Stoqno", "589624568");
            Student mariq = new Student("Mariq", "Petrova", "7453258");
            Student petar = new Student("Petar", "Dimitrow", "84256");
            Student mitko = new Student("Mitko", "Mitkov", "874235");
            Student kiro = new Student("Kiro", "kodjibashev", "98451");
            Student kosta = new Student("Kosta", "Kostadinov", "12345");
            Student dimo = new Student("Dimo", "Dimov", "654789");
            Student simo = new Student("Simo", "Simov", "4659872");
            Student angel = new Student("Angel", "Dinchev", "521489");
            Student koko = new Student("KoKO", "Dinev", "3254875");

            List<Student> studentList = new List<Student>()
            {
                gosho,
                dimitar,
                mariq,
                petar,
                mitko,
                kiro,
                kosta,
                dimo,
                simo,
                angel,
                koko,            
            };

            var sortedBynumber = studentList.OrderBy(s => s.FaultyNumber.Length).ThenBy( s => s.FaultyNumber);

            foreach (var item in sortedBynumber)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            List<Worker> workerList = new List<Worker>()
            {
                new Worker("Georgi", "Ivanov", 154.2, 8),
                new Worker("Dimitar", "Stoqno", 87.5, 10),
                new Worker("Mariq", "Petrova", 532, 8),
                new Worker("Petar", "Dimitrow", 234, 12),
                new Worker("Mitko", "Mitkov", 231, 8),
                new Worker("Kiro", "kodjibashev", 123.5, 4),
                new Worker("Kosta", "Kostadinov", 121, 8),
                new Worker("Dimo", "Dimov", 321, 8),
                new Worker("Angel", "Dinchev", 187, 8),
                new Worker("Simo", "Simov", 452, 8)
            };

            var sortedWorker = workerList.OrderByDescending(s => s.MoneyPerHour());

            foreach (var item in sortedWorker)
            {
                Console.WriteLine(item+"\n");
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(studentList);
            humans.AddRange(workerList);

            var sortedNumans = humans.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
