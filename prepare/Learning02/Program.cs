using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();

        job2._company = "NASA";
        job2._jobTitle = "Mathematician";
        job2._startYear = 2000;
        job2._endYear = 2021;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        Resume myResume = new Resume();

        myResume._Listofjobs.Add(job1);
        myResume._Listofjobs.Add(job2);

        myResume.DisplayResumeDetails();




        




    }
}