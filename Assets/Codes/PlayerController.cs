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
        // 힘에 의한 속도 변경 : 가속 방식 - 점점 속도 변화
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // 속도에 의한 변경 : 속도 지정 방식 - 정해진 속도로 세팅
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
        // if (장애물과 부딪히면)
        Die();
    }
}
