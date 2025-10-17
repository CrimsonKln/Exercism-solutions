public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitPhoneNumber = phoneNumber.Split('-');
        return (splitPhoneNumber[0].Equals("212"), splitPhoneNumber[1].Equals("555"), splitPhoneNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}