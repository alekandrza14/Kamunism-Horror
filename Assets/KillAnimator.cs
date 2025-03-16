using UnityEngine;

public class KillAnimator : MonoBehaviour
{
    public Animator animator;
    public bool killanimator;
    void Update()
    {
        if (killanimator)
        {
            animator.enabled = false;
        }
    }
}
