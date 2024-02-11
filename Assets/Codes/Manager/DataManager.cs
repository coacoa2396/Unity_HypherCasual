using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int bestScore;
    public int BestScore { get { return bestScore; } set {  bestScore = value; OnBestScoreChanged?.Invoke(bestScore); } }

    public UnityEvent<int> OnBestScoreChanged;

    [SerializeField] int curScore;
    public int CurScore
    {
        get { return curScore; } 
        set 
        {
            curScore = value;
            OnCurScoreChanged?.Invoke(curScore);
            if (curScore > BestScore)
                BestScore = curScore;
        }
    }

    public UnityEvent<int> OnCurScoreChanged;


}
