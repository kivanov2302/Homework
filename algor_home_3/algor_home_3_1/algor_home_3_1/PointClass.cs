using System;
using System.Collections.Generic;
using System.Text;

namespace algor_home_3_1
{
    public class PointStruct <T>
    {
        public T X { set; get; }
        public T Y { set; get; }
        public PointStruct(T x, T y)
        {
            X = x;
            Y = y;
        }

    }
}
