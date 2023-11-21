using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    public bool keyStatus = true;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI escapedText;
    EnemyController ec;
    PlayerDetector pd;


    void Start()
    {
        ec = GameObject.FindWithTag("Enemy").GetComponent<EnemyController>();
        pd = GameObject.FindWithTag("Exit").GetComponent<PlayerDetector>();
    }

    void Update()
    {
        if (key == false)
        {
            keyStatus = false;
        }
        
        if (keyStatus == false)
        {
            Destroy(door);
        }

        if (ec.gameOver == true)
        {
            gameOverText.gameObject.SetActive(true);
        }

        if(pd.playerEscaped == true)
        {
            escapedText.gameObject.SetActive(true);
        }
    }
}
