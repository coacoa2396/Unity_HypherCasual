using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] Transform[] children;
    [SerializeField] float scrollSpeed;
    [SerializeField] float offset;

    private void Update()
    {
        for (int i = 0; i < children.Length; i++)
        {
            children[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World);

            if (children[i].position.x < - offset)
            {
                Vector2 pos = new Vector2(offset, children[i].position.y);
                children[i].position = pos;
            }
        }
    }
}
