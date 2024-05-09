using System;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobname = "farmer";
        job1._company = "The farm";
        job1._start = 2012;
        job1._end = 2024;

        Jobs job2 = new Jobs();
        job2._jobname = "Lumberjack";
        job2._company = "The Woods";
        job2._start = 2002;
        job2._end = 2012;



        
        Resume myResume = new Resume();
        myResume._name = "Famer Greg";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



    }
}