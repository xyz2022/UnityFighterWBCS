using UnityEngine;

public class AnimationController : StateMachineBehaviour
{
    const float walkBackSpeed = 1.5f;
    const float walkForwardSpeed = -2f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (stateInfo.IsName("base.WalkBackward"))
            animator.SetFloat("WalkBackSpeed", walkBackSpeed);
        if (stateInfo.IsName("base.WalkForward"))
            animator.SetFloat("WalkForwardSpeed", walkForwardSpeed);
        if (stateInfo.IsName("base.Jump"))
            animator.SetFloat("yForce", .03f);

        if (stateInfo.IsName("base.lp"))
        {
            animator.SetBool("isCancellable", false);
        }
        if (stateInfo.IsName("base.rp"))
        {
            animator.SetBool("isCancellable", false);
        }
        if (stateInfo.IsName("base.lk"))
        {
            animator.SetBool("isCancellable", false);
        }
        if (stateInfo.IsName("base.rk"))
        {
            animator.SetBool("isCancellable", false);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("base.WalkBackward"))
            animator.SetFloat("WalkBackSpeed", 0);
        if (stateInfo.IsName("base.WalkForward"))
            animator.SetFloat("WalkForwardSpeed", 0);

        if (stateInfo.IsName("base.lp"))
        {
            animator.SetBool("pressedLP", false);
            animator.SetBool("isCancellable", true);
        }
        if (stateInfo.IsName("base.rp"))
        {
            animator.SetBool("pressedRP", false);
            animator.SetBool("isCancellable", true);
        }
        if (stateInfo.IsName("base.lk"))
        {
            animator.SetBool("pressedLK", false);
            animator.SetBool("isCancellable", true);
        }
        if (stateInfo.IsName("base.rk"))
        {
            animator.SetBool("pressedRK", false);
            animator.SetBool("isCancellable", true);
        }



    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        
    }

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

}