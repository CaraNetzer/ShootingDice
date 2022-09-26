using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            //player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            //player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            //player1.Play(large);

            Console.WriteLine("-------------------");

            Player smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Smack Talker";

            //large.Play(smackTalker);
            Console.WriteLine("-------------------");

            Player oneHigher = new OneHigherPlayer();
            oneHigher.Name = "One Higher";

            //**oneHigher only rolls one higher when they are player 1
            //oneHigher.Play(smackTalker);
            //oneHigher.Play(large);
            Console.WriteLine("-------------------");

            Player human = new HumanPlayer();
            human.Name = "Human";

            //oneHigher.Play(human);
            Console.WriteLine("-------------------");

            Player creativeTaunter = new CreativeSmackTalkingPlayer();
            creativeTaunter.Name = "Creative Taunter";

            //human.Play(creativeTaunter);
            Console.WriteLine("-------------------");

            Player soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Sore Loser";

            //**soreLoser is only a sore loser when they are player 1
            soreLoser.Play(creativeTaunter);
            soreLoser.Play(large);
            Console.WriteLine("-------------------");


            Player upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Upper Half";

            upperHalf.Play(large);
            upperHalf.Play(player1);
            Console.WriteLine("-------------------");

            Player soreLoserUpperHalf = new SoreLoserUpperHalfPlayer();
            soreLoserUpperHalf.Name = "Sore Loser Upper Half";

            soreLoserUpperHalf.Play(player2);
            soreLoserUpperHalf.Play(player1);
            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalker, oneHigher, human, creativeTaunter, soreLoser, upperHalf, soreLoserUpperHalf
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }

}