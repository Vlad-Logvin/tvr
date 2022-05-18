using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;

    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.Defend(true);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            playerAnimation.Defend(false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            playerAnimation.Attack1();
        }
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnimation.Attack2();
        }
    }
}