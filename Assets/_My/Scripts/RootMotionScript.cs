using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class RootMotionScript : MonoBehaviour
{
    Animator animator;
    public float ySpeed;
    float xSpeed;

    private void Start()
    {
        animator = GetComponent<Animator>();
        ySpeed = 0;
        xSpeed = 0;
    }

    void Update()
    {
        

        if (animator)
        {
            Vector3 newPosition = transform.position;
            xSpeed = animator.GetFloat("WalkBackSpeed") + animator.GetFloat("WalkForwardSpeed");
            newPosition.x += xSpeed * Time.deltaTime;
            float getY = animator.GetFloat("yForce");
            if (getY != 0)
            {
                ySpeed = getY;
                animator.SetFloat("yForce", 0);
                animator.SetBool("isGrounded", false);
            }
            ySpeed -= 0.0981f * Time.deltaTime;
            newPosition.y += ySpeed;
            if (newPosition.y < 0)
            {
                newPosition.y = 0;
                ySpeed = 0;
                animator.SetBool("isGrounded", true);
            }
            
            transform.position = newPosition;
        }
    }
}