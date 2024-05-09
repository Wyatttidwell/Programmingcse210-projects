using System;



public class Jobs{

    public string _jobname;
    public string _company;
    public int _start;
    public int _end;

    public void Display(){

        Console.WriteLine($"{_jobname} {_company} {_start}-{_end}");
    }
}