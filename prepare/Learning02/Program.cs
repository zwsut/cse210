using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2000";
        job1._endYear = "2010";
        job2._jobTitle = "Grandpappy";
        job2._company = "Blueberry Lane";
        job2._startYear = "1492";
        job2._endYear = "1493";

        // job1.Display();
        // job2.Display();

        Resume resume1 = new Resume();

        resume1._name = "Zach Sutherland";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();

    } 
}