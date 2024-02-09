using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] Rigidbody2D rigid;

    [Header("Specs")]
    [SerializeField] float jumpPower;

    void Jump()
    {
        // ���� ���� �ӵ� ���� : ���� ��� - ���� �ӵ� ��ȭ
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // �ӵ��� ���� ���� : �ӵ� ���� ��� - ������ �ӵ��� ����
        rigid.velocity = Vector2.up * jumpPower;
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Jump();
        }
    }
}
