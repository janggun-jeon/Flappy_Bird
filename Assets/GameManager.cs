//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float time;
    public float timing;

    private GameObject line;
    private int probability;

    public GameObject timer;
    Text runtime;

    void Start()
    {
        time = 0f;
        timing = 2f;
        line = Resources.Load("Line", typeof(GameObject)) as GameObject;
        runtime = timer.GetComponent<Text>();
    }

    void Update()
    {
        time += Time.deltaTime;
        createLine();
        runtime.text = "Running Time : " + time.ToString() + " sec";
    }



    public void createLine()
    {
        if (time >= timing)
        {
            timing += 2f;
            probability = Random.Range(0, 10);

            GameObject lineClone = Instantiate(line);
            if (probability <= 5)
            {
                lineClone.transform.position = new Vector3(80f, -40f, 0f);
            }
            else
            {
                lineClone.transform.position = new Vector3(80f, 40f, 0f);
            }
        }
    }
}
