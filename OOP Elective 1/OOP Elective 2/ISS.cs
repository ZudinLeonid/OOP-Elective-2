using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Elective_2
{
    public class ISS
    {
        private string _name;
        private double  _speed;
        private double _oxygen;
        private Point3d _position;
        private List<Astronaut> _team;

        public ISS(string name, double oxygen)
        {
            _name = name;
            _oxygen = oxygen;
            _position = new Point3d(0, 0, 0);

            _position._x = 0;
            // _position._y = 0;
            // "Point3d._y" недоступен из-за его уровня защиты
            Astronaut astronaut = new Astronaut("Ivan", 33);
            strinf nameIvan = astronaut.Name;

        }

        public void Move(Point3d point)
        {
            
        }

        public void SetPosition(Point3d point)
        {
            _position = point;
        }
    }
}
