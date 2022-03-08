namespace DesignPattern.FactoryPattern
{
    public interface IShapeFactory
    {
         public IShape GetShape(ShapeEnum shapeEnum);
    }
}