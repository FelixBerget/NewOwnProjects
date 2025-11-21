namespace NumberPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Velg 1,for å bevege høyre \n Velg 2 for å bevege venste \n Velg 3 for å bevege ned \n Velg 4 for å bevege opp");

                string answer = Console.ReadLine();
                string[] board = { " ", "1", "2", "3", "4", "5", "6", "7", "8" };
                if (answer == "1")
                {
                    board = BoardMaker.MovePieceRight();
                }
                if (answer == "2")
                {
                    board = BoardMaker.MovePieceLeft();
                }
                if (answer == "3")
                {
                    board = BoardMaker.MovePieceDown();
                }
                if (answer == "4")
                {
                    board = BoardMaker.MovePieceUp();
                }
                for (int i = 0; i < board.Length; i++)
                {
                    if (i % 3 == 2)
                    {
                        Console.WriteLine(board[i]);
                    }
                    else
                    {
                        Console.Write(board[i]);
                    }
                }
            }

        }
    }
}
