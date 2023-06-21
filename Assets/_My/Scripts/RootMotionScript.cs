using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class RootMotionScript : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        

        if (animator)
        {
            Vector3 newPosition = transform.position;
            newPosition.x += animator.GetFloat("WalkBackSpeed") * Time.deltaTime;
            newPosition.x += animator.GetFloat("WalkForwardSpeed") * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}