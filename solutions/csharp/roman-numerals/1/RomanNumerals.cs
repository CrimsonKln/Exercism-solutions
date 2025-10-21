public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string result = "";
        for (int i = 0; value >= 1000 && i < 3; i++)
        {
            result += 'M';
            value -= 1000;
        }

        switch (value)
        {
            case >= 900:
                result += "CM";
                value -= 900;
                break;
            case >= 500:
                result += "D";
                value -= 500;
                break;
            case >= 400:
                result += "CD";
                value -= 400;
                break;
            default:
                break;
        }

        for (int i = 0; value >= 100 && i < 3; i++)
        {
            result += 'C';
            value -= 100;
        }

        switch (value)
        {
            case >= 90:
                result += "XC";
                value -= 90;
                break;
            case >= 50:
                result += "L";
                value -= 50;
                break;
            case >= 40:
                result += "XL";
                value -= 40;
                break;
            default:
                break;
        }

        for (int i = 0; value >= 10 && i < 3; i++)
        {
            result += 'X';
            value -= 10;
        }

        switch (value)
        {
            case >= 9:
                result += "IX";
                value -= 9;
                break;
            case >= 5:
                result += "V";
                value -= 5;
                break;
            case >= 4:
                result += "IV";
                value -= 4;
                break;
            default:
                break;
        }

        for (int i = 0; value >= 1 && i < 3; i++)
        {
            result += 'I';
            value -= 1;
        }
        return result;
    }
}