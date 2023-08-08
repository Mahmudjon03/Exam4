using AbstractShape;
namespace Redtang;

public class Rectange:Shape
{
    double _width;
    double _lenght;
    public Rectange(Color color)
    {
        
    }
 
    public Rectange(double width, double lenght)
    {
        _lenght=lenght;
        _width=width;

    }
    public Rectange(Color color,bool fil):base(color,fil)
    {
        
    }
    public Rectange(double width, double hght,Color color,bool fil):base(color,fil)
    {
        _lenght=hght;
        _width=width;
    }
    public double GetWhith(){
        return _width;
      }
      public void SetWidth(double width){
        _width=width;
      }
      public double Getlength(){
        return _lenght;
      }
      public void SetLength(double length){
        _lenght=length;
      }
    public override double GetArea()
    {
        return _lenght*_width;
    }
    public override double GetPermetr(){
        return 2*(_lenght+_width);
    }
    public override string ToString()
    {
        return $"Rectange width:{_width} ,length:{_lenght} color {GetColor()}";
    }

}
