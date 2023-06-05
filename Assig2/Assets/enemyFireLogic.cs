using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFireLogic : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delayEnemyFire());
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    IEnumerator delayEnemyFire()
    {
        var randomShotTime = Random.Range(1.0f, 8.0f);
        yield return new WaitForSeconds(randomShotTime);
        Instantiate(obj, transform.position, transform.rotation);
        StartCoroutine(delayEnemyFire());
    }
}
