namespace Squer;
using AbstractShape;
using Redtang;
public class Squere:Rectange
{
    double _side;



    public Squere(double side, Color color,bool fil):base(color,fil)
    {
        _side=side;
    }
    public double GetSide(){
        return _side;
    }
    public void SetSide(double side){
        _side=side;
    }
    public override double GetArea(){
      return _side*_side;
    }
  public  void SetWidth(double side)
  {
    SetWidth(side);
  }

       

  public void  SetLength(double side){
     SetLength(side);
  }
  public override string ToString(){
    return $"Square side {_side} color {GetColor()}";
  }

}
