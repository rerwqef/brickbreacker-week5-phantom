using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brikescript : MonoBehaviour
{
    public int point = 1;
    public int breakhit;
    public Sprite hitesprite;
    public void breacker()
    {
        breakhit--;
        GetComponent<SpriteRenderer>().sprite = hitesprite;
    }

}
