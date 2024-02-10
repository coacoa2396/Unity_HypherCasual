using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] Rigidbody2D rigid;

    [Header("Specs")]
    [SerializeField] float jumpSpeed;
    [SerializeField] float moveSpeed;

    private void Update()
    {
        Rotate();    
    }

    void Rotate()
    {
        transform.right = rigid.velocity + Vector2.right * moveSpeed;
    }
    void Jump()
    {
        // ���� ���� �ӵ� ���� : ���� ��� - ���� �ӵ� ��ȭ
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // �ӵ��� ���� ���� : �ӵ� ���� ��� - ������ �ӵ��� ����
        rigid.velocity = Vector2.up * jumpSpeed;
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Jump();
        }
    }
}
