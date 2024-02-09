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
        // 힘에 의한 속도 변경 : 가속 방식 - 점점 속도 변화
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // 속도에 의한 변경 : 속도 지정 방식 - 정해진 속도로 세팅
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
