
//Before ISP
//var employees = SOLID.ISP.Before.Repository.LoadEmployees();

//After ISP
var employees = SOLID.ISP.After.Repository.LoadEmployees();

foreach (var e in employees)
{
    Console.WriteLine(e.PrintSalarySlip());
    Console.WriteLine();
}
Console.ReadKey();
