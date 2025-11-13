using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        if (animator == null) animator = GetComponentInChildren<Animator>();
        if (rb == null) rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // 이동 중인지 감지 (속도 기반)
        bool isRunning = new Vector3(rb.velocity.x, 0, rb.velocity.z).magnitude > 0.1f;
        animator.SetBool("Running", isRunning);

        // 점프 중인지 감지 (위쪽 속도)
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
    }
}
