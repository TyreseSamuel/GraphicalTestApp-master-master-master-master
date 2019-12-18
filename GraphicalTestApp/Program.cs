using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Tank Trouble 0.5");

            Actor root = new Actor();
            game.Root = root;

            Axis derive = new Axis(640, 380);
            root.AddChild(derive);

            game.Run();
        }
    }
}
