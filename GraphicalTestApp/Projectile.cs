using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Projectile : Entity
    {
        private Sprite _projectile;
        private AABB _box;
        private int _num;

        public Projectile(float x, float y, int num) : base(x, y)
        {
            _projectile = new Sprite("bulletDark1_outline.png");
            _box = new AABB(25, 25);
            _num = num;


            AddChild(_projectile);
            AddChild(_box);
        }
        public void Detection(float deltime)
        {
            if (_num == 1 && _box.DetectCollision(Axis.hitbox.ElementAt(0)))
            {
                Parent.RemoveChild(this);
            }
            else if (_num == 0 && _box.DetectCollision(Axis.hitbox.ElementAt(1)))
            {
                Parent.RemoveChild(this);
            }
        }
    }
}
