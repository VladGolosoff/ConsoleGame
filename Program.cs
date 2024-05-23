using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Hide cursor
        Console.CursorVisible = false;

        //Creating a map
        char[,] map = {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','o',' ',' ',' ',' ',' ',' ','#',},
            {'#','#','#',' ',' ',' ',' ',' ',' ','#','#','#','#','#',' ',' ',' ',' ',' ','#',},
            {'#','o','#',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',},
            {'#',' ',' ',' ',' ','o','#',' ',' ','#',' ',' ',' ',' ','#','#','#','#',' ','#',},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ','#','o',' ',' ',' ',' ','#',' ',' ',' ','#',},
            {'#',' ','#','#','#','#',' ',' ',' ','#','#','#',' ',' ',' ','#',' ',' ',' ','#',},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#','#','o',' ',' ','#',},
            {'#','o','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','#',' ','#',},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',},
            {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',},
            {'#',' ','#',' ',' ',' ','o','#',' ',' ','#','#','#','#','#',' ',' ','#','o','#',},
            {'#',' ','#','#',' ',' ','#','#',' ',' ',' ','#','o',' ',' ',' ',' ','#',' ','#',},
            {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ','#',' ','#',},
            {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#',},
            {'#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#',},
            {'#','o','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',}
        };

        //Player's coordinates
        int userX = 8, userY = 8;

        //Character's bag
        char[] bag = new char[1];

        //Show a map in console
        while(true) 
        {
            //Bag count
            Console.SetCursorPosition(0, 25);
            Console.Write("Bag: ");

            for (int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i] + " ");
            }

            //Set cursor position
            Console.SetCursorPosition(0,0);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
             }
            
            //Player's start position
            Console.SetCursorPosition(userY,userX);
            Console.Write('@');
            
            //Controll settings
            ConsoleKeyInfo charKey = Console.ReadKey();
            switch(charKey.Key)
            {
                case ConsoleKey.UpArrow:
                   if(map[userX - 1, userY] != '#') {
                        userX--;
                   }
                    break;
                case ConsoleKey.DownArrow:
                    if(map[userX + 1, userY] != '#') {
                        userX++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if(map[userX, userY - 1] != '#') {
                        userY--;
                     }
                    break;
                case ConsoleKey.RightArrow:
                    if(map[userX, userY + 1] != '#') {
                        userY++;
                    }
                    break;

                
            }
            // Chack for item 
            if (map[userX, userY] == 'o')
            {
                map[userX, userY] = ' ';
                char[] tempBag = new char[bag.Length +1];
                for(int i = 0; i < bag.Length; i++)
                {
                    tempBag[i] = bag[i];
                }
                tempBag[tempBag.Length - 1] = 'o';
                bag = tempBag;
            }

            // Update Console
            Console.Clear();

        }

    }
}