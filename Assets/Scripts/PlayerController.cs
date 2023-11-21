using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        { 
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        
        if (Input.GetKey(KeyCode.A)) 
        { 
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S)) 
        { 
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.D)) 
        { 
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
    }
}
