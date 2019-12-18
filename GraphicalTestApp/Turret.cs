using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Turret : Actor
    {
        private Sprite _turret;

        public Turret(float x, float y)
        {
            _turret = new Sprite("tankDark_barrel2_outline.png");

            _turret.X = -8.0f;
            _turret.Y = -45;

            X = 0;
            Y = 0;

            AddChild(_turret);


            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;
        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the Turret to the left (J)
            if (Input.IsKeyDown(74))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the Turret to the right (L)
            if (Input.IsKeyDown(76))
            {

                Rotate(1f * deltatime);
            }
        }

        public void Fire()
        {
            //Fires a shot (K)
            if (Input.IsKeyDown(75))
            {
                Projectile Shot = new Projectile(XAbsolute, YAbsolute, 0);
                Vector3 direction = GetDirectionAbsolute();
                direction.Normalize();
                direction *= 30;
                Shot.X = XAbsolute + direction.x * -8.0f;
                Shot.Y = YAbsolute + direction.y * -10;
                Shot.XVelocity = direction.x * -8.0f;
                Shot.YVelocity = direction.y * -45;
                Parent.Parent.Parent.AddChild(Shot);
            }
        }
    }
}
