using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        private AABB _outline;
        private Sprite _tank;
        private Turret _turret;

        public Tank(float x, float y, string path) : base(x, y)
        {
            _tank = new Sprite(path);
            _outline = new AABB(95, 95);
            _turret = new Turret(0, 0);

            AddChild(_tank);
            AddChild(_outline);
            AddChild(_turret);

            OnUpdate += Movement;


        }

        public Tank() : this(640, 380, "tankBody_dark_outline.png")
        {

        }

        public Tank(string path) : this(640, 380, path)
        {


        }

        public Tank(float x, float y) : this(x, y, "tankBody_dark_outline.png")
        {

        }

        public void Movement(float deltatime)
        {
            //Moves up (w)
            if (Input.IsKeyDown(83))
            {
                YVelocity = 175;
            }
            //Moves Down (s)
            else if (Input.IsKeyDown(87))
            {
                YVelocity = -90;
            }
            else
            {
                YVelocity = 0;
            }
        }
    }
}
