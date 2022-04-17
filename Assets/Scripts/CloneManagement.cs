using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneManagement : MonoBehaviour
{
    int clone = 0;

    public int GetClone()
    {
        return clone;
    }

    public int AddClone()
    {
        return clone++;
    }
}
