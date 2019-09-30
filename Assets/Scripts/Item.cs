using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void OnLook(bool isLook)
    {
        MoveDirection.isStopped = isLook;
    }
}
