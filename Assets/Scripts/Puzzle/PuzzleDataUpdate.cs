using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuzzleDataUpdate : MonoBehaviour
{
    void Start()
    {
        PuzzleData.PointPuzz = GameManager.Instance.points;
        PuzzleData.GoalPuzz = GameManager.Instance.goal;
    }

    void Update()
    {
        if (PuzzleData.PointPuzz >= PuzzleData.GoalPuzz)
        {
            PuzzleData.IncrementCurrentWin();
        }
    }
}
