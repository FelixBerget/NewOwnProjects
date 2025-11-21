namespace TestFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TurnSentence.turnTheSenctence();
        }
        static void playGame()
        {
            string numb = Guess.guessFunc();
            int intNumb = Convert.ToInt32(numb);
            if (RandomMaker.randomNum == 0)
            {
                RandomMaker.setRandom();
            }
            if (intNumb > RandomMaker.randomNum)
            {
                Console.WriteLine("Too big");
                playGame();
            }
            if (intNumb < RandomMaker.randomNum)
            {
                Console.WriteLine("Too small");
                playGame();
            }
            if (intNumb == RandomMaker.randomNum)
            {
                Console.WriteLine("Right");
            }
        }
        public static void checkword()
        {
            string senctence = wordCounter.checkWords();
            if (senctence.Length == 0) { 
                Console.WriteLine ("No input");
                return;
            }
            int numberOfWords = 1;
            for (int i = 0; i < senctence.Length; i++)
            {
                if (senctence[i] == ' ')
                {
                    numberOfWords++;
                }
            }
            Console.WriteLine("The number of words is " + numberOfWords);
        }
    }
}
