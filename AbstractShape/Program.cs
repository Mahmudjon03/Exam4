using CircleApp;
using Redtang;
using Squer;
using AbstractShape;

var circle=new Circle(4.5,Color.blue,true);
System.Console.WriteLine(circle.Getradius());
circle.SetRadius(3.51);
System.Console.WriteLine(circle.GetArea());
System.Console.WriteLine(circle.GetPermetr());
System.Console.WriteLine(circle.ToString());

var rec =new Rectange(2.3,2.5,Color.Red,true);
System.Console.WriteLine(rec.GetWhith());
rec.SetLength(5.4);
System.Console.WriteLine(rec.Getlength());
rec.SetLength(3.1);
System.Console.WriteLine(rec.GetArea());
System.Console.WriteLine(rec.GetPermetr());
System.Console.WriteLine(rec.ToString());

System.Console.WriteLine();
var sq=new Squere(3.2,Color.blue,true);
System.Console.WriteLine(sq.GetSide());
sq.SetSide(6);
sq.SetLength(5.6);
sq.SetWidth(6.5);
System.Console.WriteLine(sq.ToString());


