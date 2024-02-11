using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScoreView : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void LateUpdate()
    {
        SetScore(Manager.Data.BestScore);
    }

    void SetScore(int score)
    {
        text.text = score.ToString();
    }
}
