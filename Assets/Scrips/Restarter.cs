using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restarter : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject brid;
    public GameObject reset;

    void Start()
    {
        gameManager.GetComponent<GameManager>();
    }


    void Update()
    {
        
    }

    public void Restart()
    {
        Time.timeScale = 1;

        brid.SetActive(true);
        brid.transform.position = new Vector2(0f, 0f);

        gameManager.time = 0f;
        gameManager.timing = 2f;

        reset.SetActive(false);
    }
}
