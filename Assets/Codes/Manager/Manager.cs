using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    [SerializeField] GameManager gameManager;
    [SerializeField] DataManager dataManager;


    public static Manager GetInstance() { return instance; }
    public static GameManager Game { get { return instance.gameManager; } }
    public static DataManager Data { get { return instance.dataManager; } }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Singleton already exist");
            Destroy(this);

            return;
        }

        instance = this;
        DontDestroyOnLoad(this);

        Data.BestScore = 0;

        Application.targetFrameRate = 60;
    }
}
