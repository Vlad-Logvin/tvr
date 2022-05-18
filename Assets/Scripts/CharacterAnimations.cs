using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Walk(bool walk)
    {
        animator.SetBool(AnimationTags.WALK_PARAMETER, walk);
    }

    public void Defend(bool defend)
    {
        animator.SetBool(AnimationTags.DEFEND_PARAMETER, defend);
    }

    public void Attack1()
    {
        animator.SetTrigger(AnimationTags.ATTACK_TRIGGER_1);
    }
    
    public void Attack2()
    {
        animator.SetTrigger(AnimationTags.ATTACK_TRIGGER_2);
    }

    void FreezeAnimation()
    {
        animator.speed = 0f;
    }

    public void UnfreezeAnimation()
    {
        animator.speed = 1f;
    }
    void Update()
    {
    }
}