using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace tictactoe
{
    class Program
    {
      
      
        
        static void Main(string[] args)
        {
            var game = new Board();
         
            game.play(game);

           


        }
    }
}
