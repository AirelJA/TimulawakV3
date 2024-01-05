using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class enemyScript : MonoBehaviour
{

    private GameManager gameManagerScript;

    void Start()
    {
        
        //gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    /*private void OnTrigger(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
    }*/
}
