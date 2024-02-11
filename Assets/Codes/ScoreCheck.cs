using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    private void Awake()
    {
        Manager.Data.CurScore = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Manager.Data.CurScore++;
    }
}
