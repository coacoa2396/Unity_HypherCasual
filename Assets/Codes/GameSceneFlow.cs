using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    State state;

    public UnityEvent OnReady;
    public UnityEvent OnPlay;
    public UnityEvent OnGameOver;


    public void ChangeState(State state)
    {
        this.state = state;
        //switch
    }






    public enum State
    {
        Ready, Play, GameOver
    }
}
