
public class Monopoly
{
    Random random = new Random();
    bool done;

    public Monopoly() 
    {
        done = false;
    }

    /*
     * Goal: Write a method that takes inputs to what turn number it is and what the two dice rolls are, then returns the outcome in regurds to Monopoly rolling rules.
     * Monopoly rolling rules: Roll 2 dice, add them together, this is how far you move. if you get doubles on the 1st or 2nd roll say "You move ___. Roll again."
     * If it is your 3rd roll when you get doubles say "You rolled 3 doubles. Go to jail!"
     * On any other outcome simply say "You move ___."
     * Note: Whenever a players turn is done (meaning they are done rolling again) set done = true.
     */
    public string Roll(int rollNumber, int die1, int die2)
    {
        
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Monopoly monopoly = new Monopoly();
            Console.WriteLine(monopoly.Roll(1, monopoly.random.Next(1, 7), monopoly.random.Next(1, 7)));
            if (!monopoly.done) Console.WriteLine(monopoly.Roll(2, monopoly.random.Next(1, 7), monopoly.random.Next(1, 7)));
            if (!monopoly.done) Console.WriteLine(monopoly.Roll(3, monopoly.random.Next(1, 7), monopoly.random.Next(1, 7)));
            Console.ReadLine();
        }
    }
}

