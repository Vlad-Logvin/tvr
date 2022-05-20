using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    private bool playerDied;
    private CharacterAnimations animation;
    public bool isPlayer;
    [SerializeField] private Image healthUI;
    private CharacterSoundFX sound;

    [HideInInspector] public bool shieldActivated;

    private void Awake()
    {
        animation = GetComponent<CharacterAnimations>();
        sound = GetComponentInChildren<CharacterSoundFX>();
    }

    public void ApplyDamage(float damage)
    {
        if (shieldActivated)
        {
            return;
        }

        health -= damage;
        if (healthUI != null)
        {
            healthUI.fillAmount = health / 100f;
        }

        if (health <= 0)
        {
            playerDied = true;
        }
    }

    private void Update()
    {
        if (playerDied)
        {
            animation.Die(true);
            sound.Die();
            GetComponent<CharacterAnimations>().enabled = false;
            if (isPlayer)
            {
                GetComponent<PlayerMove>().enabled = false;
                GetComponent<PlayerAttackInput>().enabled = false;
                GameObject.FindGameObjectWithTag(Tags.ENEMY_TAG).GetComponent<EnemyController>().enabled = false;
                GameObject.FindGameObjectWithTag(Tags.ENEMY_TAG).GetComponent<CharacterAnimations>().Win();
                GameObject.FindGameObjectWithTag(Tags.ENEMY_TAG).GetComponentInChildren<CharacterSoundFX>().Victory();
                GameObject.FindGameObjectWithTag(Tags.PLAYER_BIP_TAG).GetComponent<CharacterController>().enabled =
                    false;
                StartCoroutine(DieCoroutine());
            }
            else
            {
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<EnemyController>().enabled = false;
                GetComponent<NavMeshAgent>().enabled = false;
                GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).GetComponent<CharacterAnimations>().Win();
                GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).GetComponentInChildren<CharacterSoundFX>().Victory();
                GameObject.FindGameObjectWithTag(Tags.ENEMY_BIP_TAG).GetComponent<CharacterController>().enabled =
                    false;
            }

            playerDied = false;
        }
    }
    
    IEnumerator DieCoroutine()
    {        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Scenes/Lose");
    }
}