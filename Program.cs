using ConsoleApp9;

Worker[] workers = new Worker[]
{
    new Worker("Петров", "Коля", 16, 110, false),
    new Worker("Петров", "Вася", 65, 256, true),
    new Worker("Васюкин", "Полина", 18, 170, true),
    new Worker("Джостар", "Джонатан", 74, 256, true),
    new Worker("Петров", "Герон", 15, 115, false),

};
Console.WriteLine("All Workers: ");
foreach(Worker worker in workers)
{
    Console.WriteLine( worker.ToString());
}
Console.WriteLine("All adults Worker: ");
foreach(Worker worker in workers)
{
    if (worker.Age >= 18)
    {
        Console.WriteLine( worker.ToString());
    }
}

foreach(Worker worker in workers)
{
    if(worker.Surname == "Петров")
    {
        Console.WriteLine("Month Salary: " + worker.SalaryMonth);
    }
}
double sumaMonthSalary = 0;
foreach(Worker worker in workers)
{
    if (worker.IfPensioner)
    {
        sumaMonthSalary += worker.SalaryMonth;
    }
}
Console.WriteLine("Suma month salary all pensioners: " + sumaMonthSalary);