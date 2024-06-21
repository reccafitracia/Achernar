using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    //apakah kosong atau tidak
    public bool isUseable;

    public GameObject potion;
    internal bool isUsable;

    public Node(bool _isUseable, GameObject _potion)
    {
        isUseable = _isUseable;
        potion = _potion;
    }
}
