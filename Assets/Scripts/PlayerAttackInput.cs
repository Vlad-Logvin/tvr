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
            playerAnimation.UnfreezeAnimation();
            playerAnimation.Defend(false);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerAnimation.Dance1();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            playerAnimation.Dance2();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            playerAnimation.Dance3();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            playerAnimation.Dance4();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            playerAnimation.Dance5();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            playerAnimation.Dance6();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            playerAnimation.Dance7();
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