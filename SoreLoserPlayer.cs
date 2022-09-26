using System;

namespace ShootingDice
{

    public class CustomException : Exception
    {
        public CustomException() : base() {}
    }
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            try
            {
                // Call roll for "this" object and for the "other" object
                int myRoll = Roll();
                Console.WriteLine($"{Name} rolls a {myRoll}");
                
                int otherRoll = other.Roll();
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    throw new CustomException();
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (CustomException)
            {
                Console.WriteLine($"{Name} shouts You cheated! Rematch!");
            }            
        }
    }
}