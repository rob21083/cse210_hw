using System;

public class Job
{
    public Job(string jobtitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobtitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} {_endYear}");
    }

}