using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Plattko
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rb;
        private Animator animator;

        [Header("Movement Settings")]
        private Vector2 moveInput;
        [SerializeField]private float runSpeed = 8f;
        [SerializeField]private float walkSpeed = 4f;
        [SerializeField]private float idleSlow = 0.9f;

        private bool isFacingRight = true;
        private bool isSlowWalking;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            //Debug.Log(rb.velocity.normalized);
        }

        private void FixedUpdate()
        {
            if (isSlowWalking)
            {
                Move(walkSpeed);
            }
            else
            {
                Move(runSpeed);
            }

            Flip();

            UpdateAnimationParameters();
        }

        // ---------------------------------
        // MOVEMENT METHODS
        // ---------------------------------
        private void Move(float moveSpeed)
        {
            if (moveInput != Vector2.zero)
            {
                rb.velocity = moveInput * moveSpeed;
            }
            else
            {
                rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, idleSlow);
            }
        }

        // ---------------------------------
        // SPRITE AND ANIMATIONS
        // ---------------------------------
        private void Flip()
        {
            if (isFacingRight && moveInput.x < 0 || !isFacingRight && moveInput.x > 0)
            {
                isFacingRight = !isFacingRight;
            }
        }

        private void UpdateAnimationParameters()
        {
            //if (moveInput != Vector2.zero)
            //{
            //    animator.SetFloat("Horizontal", moveInput.x);
            //    //animator.SetFloat("Vertical", moveInput.y);
            //    animator.SetFloat("Speed", moveInput.sqrMagnitude);
            //}
            //else
            //{
            //    animator.SetFloat("Speed", 0f);
            //}

            animator.SetFloat("Velocity", Mathf.Abs(rb.velocity.sqrMagnitude));

            if (isFacingRight && !isSlowWalking)
            {
                animator.SetFloat("HorizontalDirection", 1f);
            }
            else if (!isFacingRight && !isSlowWalking)
            {
                animator.SetFloat("HorizontalDirection", -1f);
            }
            else if (isFacingRight && isSlowWalking)
            {
                animator.SetFloat("HorizontalDirection", 0.33f);
            }
            else if (!isFacingRight && isSlowWalking)
            {
                animator.SetFloat("HorizontalDirection", -0.33f);
            }
        }

        // ---------------------------------
        // INPUT CHECKS
        // ---------------------------------
        public void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
        }

        public void OnUse(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                //Functionality
            }
        }

        public void OnInteract(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                //Functionality
            }
        }

        public void OnSlowWalk(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                isSlowWalking = true;
            }

            if (context.canceled)
            {
                isSlowWalking = false;
            }
        }
    }
}
