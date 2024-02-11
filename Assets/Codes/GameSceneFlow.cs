using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameSceneFlow : MonoBehaviour
{
    State state;


    public UnityEvent OnReady;
    public UnityEvent OnPlay;
    public UnityEvent OnGameOver;


    private void Start()
    {
        ChangeState(State.Ready);
    }


    public void ChangeState(State state)
    {
        this.state = state;
        switch (state)
        {
            case State.Ready:
                OnReady?.Invoke();
                break;
            case State.Play:
                OnPlay?.Invoke();
                break;
            case State.GameOver:
                OnGameOver?.Invoke();
                break;
        }
    }

    void OnGameStart(InputValue value)
    {
        if (state == State.Ready)
        {
            ChangeState(State.Play);
        }
    }

    public void GameOver()
    {
        if (state == State.Play)
        {
            ChangeState(State.GameOver);
        }
    }


    public enum State
    {
        Ready, Play, GameOver
    }
}
