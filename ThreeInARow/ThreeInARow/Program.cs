namespace ThreeInARow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameConsole game = new GameConsole();
            Board board = new Board();
            game.Show(board);
            Console.WriteLine("Hello pick where you want to set the piece");
            var pos = Console.ReadLine();
            board.Mark(Convert.ToInt32(pos));
            Thread.Sleep(2000);
            board.MarkRandom(false);
        }
    }
}
