public static class PuzzleData
{
    public static int CurrentWin = 0;

    public static void IncrementCurrentWin()
    {
        CurrentWin++;
        //Debug.Log("CurrentWin: " + CurrentWin);
    }

    public static void ResetCurrentWin()
    {
        CurrentWin = 0;
    }
}
