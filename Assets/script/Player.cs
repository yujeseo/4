using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    public Transform weaponTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (ShopUI.Instance != null && ShopUI.Instance.IsShopOpen)
        {
            moveInput = Vector2.zero;
            animator.SetFloat("Speed", 0); // 애니메이션도 멈춤
            return;
        }



        // 입력 처리
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput = moveInput.normalized;

        // 애니메이션 파라미터 설정
        animator.SetFloat("speed", moveInput.magnitude);

        // 좌우 반전 (가로 입력 있을 때만)
        if (moveInput.x != 0)
        {
            spriteRenderer.flipX = moveInput.x < 0;

            
        }
    }

    void FixedUpdate()
    {
        // 실제 이동 처리
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }



}
