using System;

namespace AreaLibrary.Figures
{
    public class Triangle : IFigure
    {
        public double GetArea(double[] _params)
        {
            double p = _params.Sum() / 2;
            return Math.Sqrt(p * (p - _params[0]) * (p - _params[1]) * (p - _params[2]));
        }
        public double GetArea(object[] _paramsObj)
        {
            return GetArea((double[])_paramsObj[0]);
        }
    }
}