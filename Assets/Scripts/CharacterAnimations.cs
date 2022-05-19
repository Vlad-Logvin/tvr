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
    
    public void Dance1()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_1);
    }
    
    public void Dance2()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_2);
    }
    
    public void Dance3()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_3);
    }
    
    public void Dance4()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_4);
    }
    
    public void Dance5()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_5);
    }
    public void Dance6()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_6);
    }
    public void Dance7()
    {
        animator.SetTrigger(AnimationTags.DANCE_TRIGGER_7);
    }
    public void Attack2()
    {
        animator.SetTrigger(AnimationTags.ATTACK_TRIGGER_2);
    }

    public void FreezeAnimation()
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