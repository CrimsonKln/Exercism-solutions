public class DndCharacter
{
    public int Strength { get; set;}
    public int Dexterity { get; set;}
    public int Constitution { get; set;}
    public int Intelligence { get; set;}
    public int Wisdom { get; set;}
    public int Charisma { get; set;}
    public int Hitpoints { get; set;}

    public static int Modifier(int score) => (int) Math.Floor((double)(score - 10) / 2);

    public static int Ability()
    {
        Random rand = new Random();
        List<int> rolls = new List<int>();
        for (int i = 0; i < 4; i++)
            rolls.Add(rand.Next(1, 7));
        
        rolls.Sort();
        return rolls[1] + rolls[2] + rolls[3];
    }

    public static DndCharacter Generate()
    {
        DndCharacter charac = new DndCharacter();
        charac.Strength = Ability();
        charac.Dexterity = Ability();
        charac.Constitution = Ability();
        charac.Intelligence = Ability();
        charac.Wisdom = Ability();
        charac.Charisma = Ability();
        charac.Hitpoints = 10 + Modifier(charac.Constitution);
        return charac;
    }
}
