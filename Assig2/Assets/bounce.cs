using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{

    private Rigidbody rigidbody;
    Vector3 latestVelocity;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        latestVelocity = rigidbody.velocity;
    }

    private void OnCollisionEnter(Collision2D collision)
    {
        var speed = latestVelocity.magnitude;
        var dir = Vector3.Reflect(latestVelocity.normalized, collision.contacts[0].normal);
        rigidbody.velocity = dir * Mathf.Max(speed, 0f);
    }
}
