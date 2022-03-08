using System;
using DesignPattern.Strings;
using System.Collections;

namespace DesignPattern
{
    public  class Program
        {
            static void Main(string[] args)
            {
                //Un-comment the below 2 lines to get repeated string program
                /*Console.WriteLine("Hello World!");
                StringOps.RepeatedString();*/

                //setup our DI
                /*
            var serviceProvider = new ServiceCollection()
                .AddTransient<IShapeFactory, ShapeFactory>()
                .AddTransient<IShapeCalculationService, ShapeCalculationService>()
                .AddScoped<Sphere>()
                .AddScoped<IShape,Sphere>(s => s.GetService<Sphere>())
                .AddScoped<Cube>()
                .AddScoped<IShape, Cube>(s => s.GetService<Cube>())
                .BuildServiceProvider();

            //do the actual work here
            var service = serviceProvider.GetService<IShapeCalculationService>();
            service.CalculateShapeMeasurements();*/


            }

    }
}
