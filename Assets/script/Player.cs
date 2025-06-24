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
            animator.SetFloat("Speed", 0); // �ִϸ��̼ǵ� ����
            return;
        }



        // �Է� ó��
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput = moveInput.normalized;

        // �ִϸ��̼� �Ķ���� ����
        animator.SetFloat("speed", moveInput.magnitude);

        // �¿� ���� (���� �Է� ���� ����)
        if (moveInput.x != 0)
        {
            spriteRenderer.flipX = moveInput.x < 0;

            
        }
    }

    void FixedUpdate()
    {
        // ���� �̵� ó��
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }



}
