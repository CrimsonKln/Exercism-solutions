public class DndCharacter
{
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public DndCharacter()
    {
        Strength = Ability();
        Dexterity = Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom = Ability();
        Charisma = Ability();
        Hitpoints = 10 + Modifier(Constitution);
    }

    public static int Modifier(int score) => (int) Math.Floor((double)(score - 10) / 2);

    public static int Ability()
    {
        Random rand = new Random();
        List<int> rolls = new List<int>();
        
        for (int i = 0; i < 4; i++)
            rolls.Add(rand.Next(1, 7));
        
        rolls.Sort();
        rolls.RemoveAt(0);
        return rolls.Sum();
    }
    
    public static DndCharacter Generate() => new DndCharacter();
}
