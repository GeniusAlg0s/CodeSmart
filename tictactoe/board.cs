using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    class Board
    {
      /* static*/ public string[] boardarr = new string[9]
       {
           "0", "1", "2", "3", "4", "5", "6", "7", "8"
       };
        public /*static*/ void board()
        {
            Console.WriteLine("|   |   |   |");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[0], boardarr[1], boardarr[2]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[3], boardarr[4], boardarr[5]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[6], boardarr[7], boardarr[8]);
            Console.WriteLine("|___|___|___|");
        }
       /* private */ public /*static*/ bool Checkwin()
        {
           
               
                if (boardarr[0] == boardarr[1] && boardarr[1]==boardarr[2])
                {
                    return true;
                }
              if (boardarr[3] == boardarr[4] && boardarr[4] == boardarr[5])
                {
                return true;
                }

            if (boardarr[6] == boardarr[7] && boardarr[7] == boardarr[8])
            {
                return true;

            }
            if (boardarr[0] == boardarr[3] && boardarr[3] == boardarr[6])
            {
                return true;

            }
            if (boardarr[1] == boardarr[4] && boardarr[4] == boardarr[7])
            {
                return true;

            }
            if (boardarr[2] == boardarr[5] && boardarr[5] == boardarr[8])
            {
                return true;

            }
            if (boardarr[0] == boardarr[4] && boardarr[4] == boardarr[8])
            {
                return true;

            }
            if (boardarr[2] == boardarr[4] && boardarr[4] == boardarr[6])
            {
                return true;

            }



            else

                return false;
            
               
            
        }
        /* private */
        public /*static*/ bool Checkdraw()
        {
            if (boardarr[0] != "0" && boardarr[1] != "1" && boardarr[2] != "2" && boardarr[3] != "3" && boardarr[4] != "4" && boardarr[5] != "5" && boardarr[6] != "6" && boardarr[7] != "7" && boardarr[8] != "8")
                return true;

            else
                return false;
        }

        public  void play(Board board)
        {
            bool gameOver = false;
             int player = 1;

            do
            {

                Console.WriteLine("welcome to tic tac toe \n player (X) one goes first\n player (O) two follows");
                Console.WriteLine();
                board.board();
                int XorO = int.Parse(Console.ReadLine());
            

                if(boardarr[XorO] != "X" && boardarr[XorO] != "O")
                {
                    if(player % 2 == 0)
                    {
                        boardarr[XorO] = "X";
                        //player = player +1;
                    }
                    else
                        boardarr[XorO] = "O";
                    player = player + 1;

                }
                else
                {
                    Console.WriteLine("already taken");
                }
                gameOver = Checkwin();
                //gameOver = Checkdraw();
            }
            while (gameOver == false);
            
        }
    }
}
