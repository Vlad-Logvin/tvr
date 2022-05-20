using UnityEngine;
using UnityEngine.AI;

public enum EnemyState
{
    CHASE,
    ATTACK
}

public class EnemyController : MonoBehaviour
{
    private CharacterAnimations enemyAnimation;
    private NavMeshAgent agent;
    private Transform playerTarget;
    public float speed = 4f;
    public float attackDistance = 2f;
    public float chasePlayerAfterAttackDistance = 1f;
    private float waitBeforeAttackTime = 3f;
    private float attackTimer;
    private EnemyState enemyState;
    public GameObject attackPointSword;
    private CharacterSoundFX sound;

    void Awake()
    {
        enemyAnimation = GetComponent<CharacterAnimations>();
        agent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
        sound = GetComponentInChildren<CharacterSoundFX>();
    }

    private void Start()
    {
        enemyState = EnemyState.CHASE;
        attackTimer = waitBeforeAttackTime;
    }

    void Update()
    {
        if (enemyState == EnemyState.CHASE)
        {
            ChasePlayer();
        }

        if (enemyState == EnemyState.ATTACK)
        {
            AttackPlayer();
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(playerTarget.position);
        agent.speed = speed;
        if (agent.velocity.sqrMagnitude == 0)
        {
            enemyAnimation.Walk(false);
        }
        else
        {
            enemyAnimation.Walk(true);
        }

        if (Vector3.Distance(transform.position, playerTarget.position) <= attackDistance)
        {
            enemyState = EnemyState.ATTACK;
        }
    }

    void AttackPlayer()
    {
        agent.velocity = Vector3.zero;
        agent.isStopped = true;

        enemyAnimation.Walk(false);
        attackTimer += Time.deltaTime;
        if (attackTimer > waitBeforeAttackTime)
        {
            if (Random.Range(0, 2) > 0)
            {
                sound.Attack1();
                enemyAnimation.Attack1();
            }
            else
            {
                sound.Attack2();
                enemyAnimation.Attack2();
            }

            attackTimer = 0f;
        }

        if (Vector3.Distance(transform.position, playerTarget.position) <
            attackDistance + chasePlayerAfterAttackDistance)
        {
            agent.isStopped = false;
            enemyState = EnemyState.CHASE;
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
}