using Employe;
var emp=new Emploee(1,"Ali","Vali",800);
System.Console.WriteLine(emp.GetId());
System.Console.WriteLine(emp.GetFirstName());
System.Console.WriteLine(emp.GetLastName());
System.Console.WriteLine(emp.GetSalary());
System.Console.WriteLine(emp.GetAnualSalary());
emp.SetSalary(1200);
System.Console.WriteLine(emp.RaiseSalary(10));
System.Console.WriteLine(emp.ToString());

