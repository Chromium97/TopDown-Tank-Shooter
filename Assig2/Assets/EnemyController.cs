using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform moveToHero;
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private int health = 3;
    [SerializeField] private float desestructionDelay = 0f;



    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cannonBall") 
        {
            health = health - 1;
            if (health < 0)
            {
                Invoke("DestroyCollisionObj", desestructionDelay);
            }
        }
        
    }

    private void DestroyCollisionObj()
    {
        Destroy(this.gameObject);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(HeroController.currentPosition);
        navMeshAgent.destination = moveToHero.position;
    }

   
}
