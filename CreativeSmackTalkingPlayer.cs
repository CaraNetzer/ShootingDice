using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts = new List<string>()
        {
            "Suck it!",
            "Take that!",
            "Na-na-na-na-na",
            "*laughs maniacally*"
        };

        public override int Roll()
        {

            Random randomNumberGenerator = new Random();
            List<string> shuffledTaunts = Taunts.OrderBy(t => randomNumberGenerator.Next()).ToList();
            string taunt = $"{Name} shouts {shuffledTaunts[0]}";
            Console.WriteLine(taunt);
            // Return a random number between 1 and DiceSize
            return new Random().Next(1,DiceSize+1);
        }
    }
}