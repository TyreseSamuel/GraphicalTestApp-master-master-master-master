using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Axis : Entity
    {
        private Tank _tank;
        private AABB _boxline;
        private int _num;
        static public List<AABB> hitbox = new List<AABB>();

        public Axis(float x, float y) : base(x, y)
        {
            _tank = new Tank(0, 0);


            AddChild(_tank);

            OnUpdate += TankAxis;
            OnUpdate += Rotateright;
            OnUpdate += Rotateleft;
        }

        public void TankAxis(float deltatime)
        {

            _tank.Y = 0;
            X = _tank.XAbsolute;
            Y = _tank.YAbsolute;
        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the Tank to the left (A)
            if (Input.IsKeyDown(65))
            {
                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the Tank to the right (D)
            if (Input.IsKeyDown(68))
            {
                Rotate(1f * deltatime);
            }
        }
    }
}
