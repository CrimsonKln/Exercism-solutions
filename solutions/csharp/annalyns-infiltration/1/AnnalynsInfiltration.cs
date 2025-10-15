static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool canFreePrisoner = false;
        if ((petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && !knightIsAwake && !archerIsAwake && prisonerIsAwake)) {
            canFreePrisoner = true;
        }
        return canFreePrisoner;
    }
}
