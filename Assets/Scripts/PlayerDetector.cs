using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameObject player;
    public bool playerEscaped = false;

    void Start()
    {
        
    }

    void Update()
    {
    
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(player);
            playerEscaped = true;
        }
    }
}
