using System;
using System.Security.Cryptography.X509Certificates;

namespace DesignPattern.FactoryPattern
{
    public class ShapeFactory : IShapeFactory
    {
       
       private readonly IServiceProvider _serviceProvider;


        public IShape GetShape(ShapeEnum senum)
        {
            switch (senum)
            {
                case ShapeEnum.Cube:
                return (IShape) _serviceProvider.GetService(typeof(Cube));
                case ShapeEnum.Sphere:
                return (IShape) _serviceProvider.GetService(typeof(Sphere));
                 default:
                    throw new ArgumentOutOfRangeException(nameof(senum), senum, $"Shape of {senum} is not supported.");
            }

        }
        
    }
}