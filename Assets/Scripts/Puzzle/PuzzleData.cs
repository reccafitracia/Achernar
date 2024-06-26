public static class PuzzleData
{
    public static int PointPuzz { get; set; }
    public static int GoalPuzz { get; set; }
    public static int CurrentWin { get; set; }

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
