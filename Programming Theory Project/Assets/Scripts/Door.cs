using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    protected bool isOpen;
    protected bool isLocked;
    protected bool isInRange;

    protected float openTimer;
    protected float openTime;
    public virtual void Open()
    {  
        if (!isOpen & !isLocked)
        {
            isOpen = true;
            openTimer = openTime;
        }
    }

    protected void unlock()
    {
        isLocked = false;
    }


    protected virtual void Close()
    {
        isOpen = false;
    }
}
