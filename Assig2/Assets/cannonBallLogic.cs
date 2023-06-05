using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBallLogic : MonoBehaviour
{
    [SerializeField] private float desestructionDelay = 8f;

    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, desestructionDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
