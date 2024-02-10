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
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
