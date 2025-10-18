public class Player
{
    public int RollDie()
    {
        Random rand = new();
        return rand.Next(18) + 1;
    }

    public double GenerateSpellStrength()
    {
        Random rand = new();
        return rand.NextDouble() * 100;
    }
}
