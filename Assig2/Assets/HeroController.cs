using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    [Header("debug")]
    [SerializeField] private Vector2 axis;
    [SerializeField] public static Vector3 currentPosition;
    [SerializeField] public static Vector3 resetPosition;

    [SerializeField] private float rotSpeed = 8;
    [SerializeField] private float moveSpeed = 8;
    [SerializeField] private int health = 3;
    [SerializeField] private float desestructionDelay = 0f;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cannonBall")
        {
            health -= 1;
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

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = transform.position;
    }
    

    private void HeroControlUpdate()
    {

        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");

        this.transform.RotateAround(Vector3.up, rotSpeed * axis.x * Time.deltaTime);
        this.transform.Translate(moveSpeed * axis.y * Time.deltaTime * this.transform.forward, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        HeroControlUpdate();
        resetHero();


    }

    public void resetHero()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            transform.position = resetPosition;
        }
    }



}
