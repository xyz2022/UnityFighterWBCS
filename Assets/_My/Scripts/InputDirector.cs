using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDirector : MonoBehaviour
{


    public KeyCode keyUp;
    public KeyCode keyDown;
    public KeyCode keyLeft;
    public KeyCode keyRight;
    public KeyCode keyLPunch;
    public KeyCode keyRPunch;
    public KeyCode keyLKick;
    public KeyCode keyRKick;

    private InputDirector inputDirector;
    private Animator animator;

    void Awake()
    {
        inputDirector = GetComponentInChildren<InputDirector>();
        animator = GetComponentInChildren<Animator>();

    }


    private void Update()
    {
        if(Input.GetKeyDown(keyLPunch))
        {
            animator.SetBool("pressedLP", true);
        }
        if (Input.GetKeyDown(keyRPunch))
        {
            animator.SetBool("pressedRP", true);
        }
        if (Input.GetKeyDown(keyLKick))
        {
            animator.SetBool("pressedLK", true);
        }
        if (Input.GetKeyDown(keyRKick))
        {
            animator.SetBool("pressedRK", true);
        }
        if (Input.GetKeyDown(keyLeft))
        {
            animator.SetBool("pressedLeft", true);
        }
        if (Input.GetKeyUp(keyLeft))
        {
            animator.SetBool("pressedLeft", false);
        }
    }


}
