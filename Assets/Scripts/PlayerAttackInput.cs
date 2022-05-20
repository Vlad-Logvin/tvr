using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;
    public GameObject attackPointSword, attackPointHand, attackPointLeg;
    private PlayerShield shield;
    private CharacterSoundFX sound;

    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
        shield = GetComponent<PlayerShield>();
        sound = GetComponentInChildren<CharacterSoundFX>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            sound.Defence();
            playerAnimation.Defend(true);
            shield.ActiveShield(true);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            playerAnimation.UnfreezeAnimation();
            playerAnimation.Defend(false);
            shield.ActiveShield(false);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            sound.Dance();
            playerAnimation.Dance1();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            sound.Dance();
            playerAnimation.Dance2();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            sound.Dance();
            playerAnimation.Dance3();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            sound.Dance();
            playerAnimation.Dance4();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            sound.Dance();
            playerAnimation.Dance5();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            sound.Dance();
            playerAnimation.Dance6();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            sound.Dance();
            playerAnimation.Dance7();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            sound.Attack1();
            playerAnimation.Attack1();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            sound.Attack2();
            playerAnimation.Attack2();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            sound.LeftHandAttack();
            playerAnimation.LeftHandAttack();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            sound.LegAttack();
            playerAnimation.LegAttack();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            sound.LegSweepAttack();
            playerAnimation.LegSweepAttack();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            sound.LeftSwiping();
            playerAnimation.LeftSwiping();
        }
    }

    void ActivateAttackPointSword()
    {
        attackPointSword.SetActive(true);
    }

    void DeactivateAttackPointSword()
    {
        if (attackPointSword.activeInHierarchy)
        {
            attackPointSword.SetActive(false);
        }
    }

    void ActivateAttackPointLeg()
    {
        attackPointLeg.SetActive(true);
    }

    void DeactivateAttackPointLeg()
    {
        if (attackPointLeg.activeInHierarchy)
        {
            attackPointLeg.SetActive(false);
        }
    }

    void ActivateAttackPointHand()
    {
        attackPointHand.SetActive(true);
    }

    void DeactivateAttackPointHand()
    {
        if (attackPointHand.activeInHierarchy)
        {
            attackPointHand.SetActive(false);
        }
    }
}