public static class RomanNumeralExtension
{
    private static Dictionary<int, string[]> stringTranscriptions = new Dictionary<int, string[]>()
        {
            {1000, ["", "M", "MM", "MMM"]},
            {100, ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"]},
            {10, ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"]},
            {1, ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"]}
        };
    
    public static string ToRoman(this int value)
    {        
        string result = "";
            foreach ((int scale, string[] transcription) in stringTranscriptions)
            {
                int cpt = 0;
                while (value >= scale)
                {
                    value -= scale;
                    cpt++;
                }
                result += transcription[cpt];
            }
        return result;
    }
}