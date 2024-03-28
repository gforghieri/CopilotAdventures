using System;
using System.Collections.Generic;

public enum DanceMove
{
    Twirl,
    Leap,
    Spin
}

public class Creature
{
    public string Name { get; set; }
    public List<DanceMove> DanceMoves { get; set; }
}

public class Forest
{
    public string State { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // Initialize the state of the forest
        Forest forest = new Forest { State = "Normal" };

        // Initialize creatures and their dance moves
        Creature lox = new Creature { Name = "Lox", DanceMoves = new List<DanceMove> { DanceMove.Twirl, DanceMove.Leap, DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap } };
        Creature drako = new Creature { Name = "Drako", DanceMoves = new List<DanceMove> { DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap, DanceMove.Leap, DanceMove.Spin } };

        // Perform the dance
        for (int i = 0; i < 5; i++)
        {
            DanceMove loxMove = lox.DanceMoves[i];
            DanceMove drakoMove = drako.DanceMoves[i];

            // Determine the effect of the combined dance moves on the forest
            if (loxMove == DanceMove.Twirl && drakoMove == DanceMove.Twirl)
            {
                forest.State = "Fireflies light up the forest";
            }
            else if (loxMove == DanceMove.Leap && drakoMove == DanceMove.Spin)
            {
                forest.State = "Gentle rain starts falling";
            }
            else if (loxMove == DanceMove.Spin && drakoMove == DanceMove.Leap)
            {
                forest.State = "A rainbow appears in the sky";
            }
            else if (loxMove == DanceMove.Twirl && drakoMove == DanceMove.Leap)
            {
                forest.State = "A gust of wind sweeps through the forest";
            }
            else if (loxMove == DanceMove.Leap && drakoMove == DanceMove.Twirl)
            {
                forest.State = "The forest is filled with a beautiful melody";
            }
            else if (loxMove == DanceMove.Spin && drakoMove == DanceMove.Spin)
            {
                forest.State = "A flurry of leaves swirls around the forest";
            }
            else
            {
                forest.State = "No special effect";
            }

            // Display the state of the forest after each sequence
            Console.WriteLine($"After sequence {i + 1}, the state of the forest is: {forest.State}");
        }

        // Display the final state of the forest after the dance is complete
        Console.WriteLine($"The final state of the forest after the dance is: {forest.State}");
    }

}


