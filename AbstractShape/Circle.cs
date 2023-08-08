using AbstractShape;
namespace CircleApp;

public class Circle:Shape
{
    double _radius;
    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        _radius=radius;
    }
    public Circle(double radius,  Color color,bool fil):base(color,fil)
    {
        _radius=radius;
    }
    public double Getradius(){
        return _radius;
    }
    public void SetRadius(double radius){
        _radius=radius;
    }
    public override string ToString(){
    return $"Circle radius :{Getradius()} color {GetColor()}";
    }
    public override double GetArea()
    {
        return _radius*_radius*3.14;
    }
    public override double GetPermetr()
    {
      return _radius*3.14*2;
    }




}
