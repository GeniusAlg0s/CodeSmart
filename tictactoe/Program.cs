using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace tictactoe
{
    class Program
    {
      
        // static string choice;
       // static int player = 1;
       // static int XorO;
        
        static void Main(string[] args)
        {
            var game = new Board();
           // bool gameOver = false;

            game.play(game);

            // game.board();
            // Board();
            //game.Checkwin();
         /*  do
            {
                Console.WriteLine("welcome to tic tac toe \n player (X) one goes first\n player (O) two follows");
                Console.WriteLine();
                game.board();
               int XorO = int.Parse(Console.ReadLine());

               
            }
            while (gameOver == false ); 
             */


        }
    }
}
