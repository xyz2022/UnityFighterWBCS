using UnityEngine;

public class AnimationController : StateMachineBehaviour
{


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("pressedLP", false);
        animator.SetBool("pressedRP", false);
        animator.SetBool("pressedLK", false);
        animator.SetBool("pressedRK", false);
        //animator.SetBool("pressedLeft", false);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

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