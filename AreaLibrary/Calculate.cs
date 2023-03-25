using System;
using System.Reflection;
using AreaLibrary.Figures;

namespace AreaLibrary
{
    public class Calculate
    {
        public static double CalculateArea(double[] _params, string figureName = "")
        {
            double area = 0;
            if (figureName == "")
            {
                switch (_params.Length)
                {
                    case 1:
                        Circle circle = new Circle();
                        area = circle.GetArea(_params);
                        break;
                    case 3:
                        Triangle triangle = new Triangle();
                        area = triangle.GetArea(_params);
                        break;
                    default:
                        throw new Exception("Invalid arguments");
                }
            }
            else
            {
                Type type = Type.GetType("AreaLibrary.Figures." + figureName);
                if (type == null)
                    throw new Exception("Invalid figure name");
                object figure = Activator.CreateInstance(type);
                area = Convert.ToDouble(type.GetMethod("GetArea",new Type[] {typeof(object[])})
                .Invoke(figure, new[] { _params }));
            }
            return area;
        }
    }
}
