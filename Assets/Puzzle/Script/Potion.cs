using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    public PotionType potionType;

    public int xIndex;
    public int yIndex;

    public bool isMatched;
    private Vector2 currentPos;
    private Vector2 targetPos;

    public bool isMoving;

    public Potion(int _x, int _y)
    {
        this.xIndex = _x;
        this.yIndex = _y;
    }

    public void SetIndicies(int _x, int _y)
    {
        this.xIndex = _x;
        this.yIndex = _y;
    }


}

public enum PotionType
{
    Red,
    Blue,
    Purple,
    Green,
    White
}
