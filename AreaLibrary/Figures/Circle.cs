using System;

namespace AreaLibrary.Figures
{
    public class Circle : IFigure
    {
        public double GetArea(double[] _params)
        {
            return Math.PI * Math.Pow(_params[0], 2);
        }
        public double GetArea(object[] _paramsObj)
        {
            return GetArea((double[])_paramsObj[0]);
        }
    }
}
