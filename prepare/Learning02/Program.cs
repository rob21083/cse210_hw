using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software", 2022, 2023);
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        Job job2;
        job2 = new Job("Apple", "Manager", 2022, 2023);
        // job2._company = "Apple";
        // job2._jobTitle = "Manager";
        // job2._endYear = 2022;
        // job2._startYear = 2023; 

        Resume myResume = new Resume();
        myResume._name = "David Roberts";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}