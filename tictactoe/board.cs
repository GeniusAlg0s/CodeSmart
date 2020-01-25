using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    class Board
    {
      public string[] boardarr = new string[9]
       {
           "0", "1", "2", "3", "4", "5", "6", "7", "8"
       };
        public  void board()
        {
            Console.WriteLine("|   |   |   |");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[0], boardarr[1], boardarr[2]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[3], boardarr[4], boardarr[5]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine(" {0}  | {1} | {2} |", boardarr[6], boardarr[7], boardarr[8]);
            Console.WriteLine("|___|___|___|");
        }
        public  bool Checkwin( )
        {
           
               
                if (boardarr[0] == boardarr[1] && boardarr[1]==boardarr[2])
                {

                Console.WriteLine(" Last player Won!!!");
                return true;
                }
              if (boardarr[3] == boardarr[4] && boardarr[4] == boardarr[5])
                {
                Console.WriteLine(" Last player Won!!!");
                return true;
                }

            if (boardarr[6] == boardarr[7] && boardarr[7] == boardarr[8])
            {
                Console.WriteLine(" Last player Won!!!");
                return true;

            }
            if (boardarr[0] == boardarr[3] && boardarr[3] == boardarr[6])
            {
                Console.WriteLine(" Last player Won!!!");
                return true;

            }
            if (boardarr[1] == boardarr[4] && boardarr[4] == boardarr[7])
            {
                Console.WriteLine(" Last player Won!!!");
                return true;

            }
            if (boardarr[2] == boardarr[5] && boardarr[5] == boardarr[8])
            {
                Console.WriteLine(" Last player who went Won!!!");
                return true;

            }
            if (boardarr[0] == boardarr[4] && boardarr[4] == boardarr[8])
            {
                Console.WriteLine(" Last player Won!!!");


              
                return true;

            }
            if (boardarr[2] == boardarr[4] && boardarr[4] == boardarr[6])
            {
                Console.WriteLine(" Last player Won!!!");
                return true;

            }



            else

                return false;
            
               
            
        }
       
        public  bool Checkdraw()
        {
            if (boardarr[0] != "0" && boardarr[1] != "1" && boardarr[2] != "2" && boardarr[3] != "3" && boardarr[4] != "4" && boardarr[5] != "5" && boardarr[6] != "6" && boardarr[7] != "7" && boardarr[8] != "8")
            {
                Console.WriteLine(" This was a draw");
                return true; }

            else

                return false;
        }
        public void Validate(int choice)
        {
            
            if (choice == 0 || choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7 || choice == 8 )
            {
                Console.WriteLine("valid entry next player's turn");
            }

            else
            {
                Console.WriteLine("invalid entry the game will not end You have entered the relm of epic faliure and lost");
            }
        }

        public  void play(Board board)
        {
            bool gameOverW = false;
            bool gameOverD = false;
            int player = 1;


              do
             {
        

                Console.WriteLine("welcome to tic tac toe \n player (X) one goes first\n player (O) two follows");
                Console.WriteLine();
                Console.WriteLine("RULES: pic a number 0 - 8. Not follwoing rules leads to automatic loss and game ending");
                board.board();
                Console.WriteLine("Enter the value:");
                int XorO = int.Parse(Console.ReadLine());
                board.Validate(XorO);

              

                if (boardarr[XorO] != "X" && boardarr[XorO] != "O")
                {


                    if (player % 2 == 0)
                    {
                        boardarr[XorO] = "X";
                       
                    }
                    else
                        boardarr[XorO] = "O";
                    player = player + 1;

                }
                else
                {
                    Console.WriteLine("already taken");
                }


                gameOverW = Checkwin();
                gameOverD = Checkdraw();
            }
                
          

           while (gameOverW == false && gameOverD == false);

            Console.Clear();// clearing the console  

            board.board();

            if (gameOverW == true || gameOverD == true)
                {
                    Console.WriteLine("the game is over ");

                }
            
            
        }
    }
}
