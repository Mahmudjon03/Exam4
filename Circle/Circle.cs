namespace Circlee;

public class Circle
{
    double _radius;
     public   const double pi=3.14;
     public Circle()
     {
     }
     public Circle(double radius)
     {
        _radius=radius;
     }
     public double GetRadius( ){
        return _radius;
     }
     public void SetRadius(double radius){
        _radius=radius;
     }
     public double GetArea(){
        return pi*_radius*_radius;
     }
     public double GetCircumference(){
        return 2*_radius*pi;
     }
public string ToString(){
    return "Cicle[radius=" + _radius + "]";
}
     }
