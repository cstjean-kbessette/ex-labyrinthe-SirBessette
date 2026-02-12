using System.Net.Http.Headers;

namespace Labyrinthe
{
    internal class Controller
    {
        View view = new View();
        Labyrinthe lab1 = new Labyrinthe();

        public Controller(View view, Labyrinthe lab1)
        {
            this.view = view;
            this.lab1 = lab1;
        }
        public void Run()
        {
            while (true)
            {
                view.AfficherEntete();
                view.AfficherLabyrinth(lab1);
                ConsoleKeyInfo bouge = Console.ReadKey();
                
                switch(bouge.Key)
                {
                    case ConsoleKey.UpArrow:
                        lab1.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        lab1.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        lab1.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        lab1.MoveRight();
                        break;
                }
                if (lab1.IsExit())
                {
                    view.AfficherVictoire();
                    Console.ReadKey();
                    break;
                }


            }

        }   
    }
}
