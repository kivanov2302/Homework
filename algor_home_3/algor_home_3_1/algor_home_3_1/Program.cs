using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;



namespace algor_home_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {
        //Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
        [Benchmark]
        public void testPointDistance()
        {
            float x = 10;
            float y = 20;
            var pointOne = new PointStruct<float>(x, y);
            x = 30;
            y = 20;
            var pointTwo = new PointStruct<float>(x, y);
            PointDistance(pointOne, pointTwo);
        }
        public float PointDistance(PointStruct<float> pointOne, PointStruct<float> pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        //Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
        [Benchmark]
        public void testPointDistanceRef()
        {
            float x = 10;
            float y = 20;
            var pointOne = new PointStruct<float>(x, y);
            x = 30;
            y = 20;
            var pointTwo = new PointStruct<float>(x, y);
            PointDistanceRef(ref pointOne, ref pointTwo);
        }
        public float PointDistanceRef(ref PointStruct<float> pointOne, ref PointStruct<float> pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        //Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
        [Benchmark]
        public void testPointDistanceShort()
        {
            float x = 10;
            float y = 20;
            var pointOne = new PointStruct<float>(x, y);
            x = 30;
            y = 20;
            var pointTwo = new PointStruct<float>(x, y);
            PointDistanceShort(pointOne, pointTwo);
        }
        public float PointDistanceShort(PointStruct<float> pointOne, PointStruct<float> pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        //Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
        [Benchmark]
        public void testPointDistanceDouble()
        {
            double x = 10;
            double y = 20;
            var pointOne = new PointStruct<double>(x, y);
            x = 30;
            y = 20;
            var pointTwo = new PointStruct<double>(x, y);
            PointDistanceDouble(pointOne, pointTwo);
        }
        public double PointDistanceDouble(PointStruct<double> pointOne, PointStruct<double> pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
    }
}
