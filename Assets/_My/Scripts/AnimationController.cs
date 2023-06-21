using UnityEngine;

public class AnimationController : StateMachineBehaviour
{
    const float walkBackSpeed = 1.5f;
    const float walkForwardSpeed = -2f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //  if (stateInfo.IsName("base.idle_A"))
        //  {
        //      animator.SetBool("pressedLP", false);
        //      animator.SetBool("pressedRP", false);
        //      animator.SetBool("pressedLK", false);
        //      animator.SetBool("pressedRK", false);
        //  }
        //animator.SetBool("pressedLeft", false);
        //Debug.Log(stateInfo.shortNameHash.ToString());
        if (stateInfo.IsName("base.WalkBackward"))
            animator.SetFloat("WalkBackSpeed", walkBackSpeed);
        if (stateInfo.IsName("base.WalkForward"))
            animator.SetFloat("WalkForwardSpeed", walkForwardSpeed);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("base.WalkBackward"))
            animator.SetFloat("WalkBackSpeed", 0);
        if (stateInfo.IsName("base.WalkForward"))
            animator.SetFloat("WalkForwardSpeed", 0);

        if (stateInfo.IsName("base.lp"))
            animator.SetBool("pressedLP", false);
        if (stateInfo.IsName("base.rp"))
            animator.SetBool("pressedRP", false);
        if (stateInfo.IsName("base.lk"))
            animator.SetBool("pressedLK", false);
        if (stateInfo.IsName("base.rk"))
            animator.SetBool("pressedRK", false);


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