using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipLineMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
    {
        if (Manager.Data.CurScore < 50)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        else if (Manager.Data.CurScore >= 50)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime * 1.5f);
        }
        else if (Manager.Data.CurScore >= 100)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime * 2f);
        }

    }
}
