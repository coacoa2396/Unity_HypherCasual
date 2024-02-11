using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] Animator animator;

    [Header("Specs")]
    [SerializeField] float jumpSpeed;
    [SerializeField] float moveSpeed;

    [Header("Events")]
    [SerializeField] UnityEvent OnDied;
    [SerializeField] UnityEvent OnJumped;

    private void Start()
    {
        Jump();
    }

    private void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.right = rigid.velocity + Vector2.right * moveSpeed;
    }

    public void Jump()
    {
        // ���� ���� �ӵ� ���� : ���� ��� - ���� �ӵ� ��ȭ
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // �ӵ��� ���� ���� : �ӵ� ���� ��� - ������ �ӵ��� ����
        rigid.velocity = Vector2.up * jumpSpeed;
        OnJumped?.Invoke();
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Jump();
        }
    }

    void Die()
    {
        OnDied?.Invoke();
        animator.SetBool("Die", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if (��ֹ��� �ε�����)
        Die();
    }
}
