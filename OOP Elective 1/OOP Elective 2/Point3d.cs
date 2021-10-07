using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Elective_2
{
    public class Point
    {
        public double _x;
        private double _y;
    }
    
    class Point3d : Point
    {
        private double _x;
        private double _y;
        private double _z;

        public Point3d()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Point3d(double x, double y, double z)
        {

        }
    }
}
