using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new()
        {
            _name = "Anton Syzov"
        };

        Job job1 = new()
        {
            _jobTitle = "Software Engineer",
            _company = "Netflix",
            _startYear = 2013,
            _endYear = 2015
        };

        Job job2 = new()
        {
            _jobTitle = "DevOps Engineer",
            _company = "Highscore Technologies",
            _startYear = 2017,
            _endYear = 2018
        };

        myResume._jobs.AddRange([job1, job2]);

        myResume.Display();
    }
}