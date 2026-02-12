namespace Labyrinthe
{
    internal class View
    {
        
        public void AfficherEntete()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le Labyrinthe !");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Atteignez la sortie 'E' pour gagner !");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }

        public void AfficherLabyrinth(Labyrinthe lab1)
        {
            for (int i = 0; i < lab1.Map.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < lab1.Map.GetLength(1); j++)
                {
                    if (j == lab1.PosX && i == lab1.PosY)
                    {
                        Console.Write('O');
                    }
                    else
                    {
                        Console.Write(lab1.Map[j, i]);
                    }
                }
            }
        }

        public void AfficherVictoire()
        {
            Console.Clear();
            Console.WriteLine("Félicitations ! Vous avez trouvé la sortie !");
            Console.WriteLine("Merci d'avoir joué !");
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
