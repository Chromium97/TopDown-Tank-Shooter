using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour
{
    [Header("CannonBall")]
    [SerializeField] private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ShotLogicUpdate() {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(obj, transform.position, transform.rotation);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        ShotLogicUpdate();
    }
}
