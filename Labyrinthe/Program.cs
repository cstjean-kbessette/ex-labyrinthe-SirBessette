namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe lb1 = new Labyrinthe();
            View view = new View();

            Controller cont = new Controller(view, lb1);

            cont.Run();
        }
    }
}
