using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelCheck : MonoBehaviour
{
    [SerializeField] int scoreCheck;

    public UnityEvent On30Score;
    public UnityEvent On50Score;
    public UnityEvent On80Score;
    public UnityEvent On100Score;

    

    

    void Update()
    {

        scoreCheck = Manager.Data.CurScore;

        if (scoreCheck >= 30)
        {
            On30Score?.Invoke();
        }
        else if (scoreCheck >= 50)
        {
            On50Score?.Invoke();
        }
        else if (scoreCheck >= 80)
        {
            On80Score?.Invoke();
        }
        else if (scoreCheck >= 100)
        {
            On100Score?.Invoke();
        }
    }

  
}
