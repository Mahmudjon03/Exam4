namespace AbstractShape;

public abstract class Shape
{
    protected Color _color;

    public bool _files;
    public Shape()
    {
        
    }
    
    public Shape(Color color,bool files){
        _color = color;
        _files = files;
    }
    public Enum GetColor(){
        return _color;
    }
    public void SetColor(Color color){
        _color = color;
    }
    abstract public double  GetArea();
    abstract public double GetPermetr();
}
 public enum Color{
        Red=1,
        blue=2
    }