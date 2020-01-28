using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbtac
{
    class Program
    {
        static void Main(string[] args)
        {
            Board newgame = new Board();
            newgame.play(newgame);
        }
    }
}
