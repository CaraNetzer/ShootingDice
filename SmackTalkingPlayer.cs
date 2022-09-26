using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt {get;set;}
        public override int Roll()
        {
            Taunt = $"{Name} shouts Suck it!";
            Console.WriteLine(Taunt);
            // Return a random number between 1 and DiceSize
            return new Random().Next(1,DiceSize+1);
        }
    }
}