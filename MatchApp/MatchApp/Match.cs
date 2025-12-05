using System;
using System.Collections.Generic;
using System.Text;

namespace MatchApp
{
    internal class Match
    {

        int homeGoals = 0;
        int awayGoals = 0;
        bool matchIsRunning = true;

        public void StartGame()
        {
            Console.Write("Gyldig tips: \n" +
" - H, U, B\n" +
" - halvgardering: HU, HB, UB\n" +
" - helgardering: HUB\n" +
"Hva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            while (matchIsRunning)
            {
                SetTheResult();
            }
            CalculateResult(bet);

        }

        public void SetTheResult()
        {
            Console.Write("Kommandoer: \n" +
    " - H = scoring hjemmelag\n" +
    " - B = scoring bortelag\n" +
    " - X = kampen er ferdig\n" +
    "Angi kommando: ");
            var command = Console.ReadLine();
            matchIsRunning = command != "X";
            if (command == "H") homeGoals++;
            else if (command == "B") awayGoals++;
            Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
        }

        public void CalculateResult(string bet)
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
