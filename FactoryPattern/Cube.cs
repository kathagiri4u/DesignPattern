using System;
namespace DesignPattern.FactoryPattern
{
    public class Cube : IShape
    {
        public decimal  Side {get;set;}

        public void GetInputValues()
        {
            Console.WriteLine("Side:");
            Side = decimal.Parse(Console.ReadLine());

        }
        
        public void DisplaySurFaceArea()
        {
            Console.WriteLine("Surface of the Cube is {0}: ", +Side*Side*6);
        }

        public void DisplayVolume()
        {
            Console.WriteLine("Volume of the Cube is :" + (Side * Side * Side));
        }
    }
}