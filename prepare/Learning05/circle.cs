public class circle : shape{
    private double _radius;

    public circle(string color, double radius) : base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}