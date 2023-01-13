using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brid : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float gravity;
    public float height;

    Animator ani;

    public GameObject reset;
    bool flag;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        gravity = 10f;
        height = 20f;

        ani = gameObject.GetComponent<Animator>();

        reset.SetActive(false);
        flag = false;
    }

    void Update()
    {
        rigidbody.AddForce(Vector3.down * gravity, ForceMode2D.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            flag = true;
        }
    }


    private void FixedUpdate()
    {
        if (flag)
        {
            rigidbody.velocity = new Vector3(0, transform.up.y * height, 0);

            ani.SetTrigger("fly");
            flag = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn" || other.tag == "Finish")
        {
            GameObject[] removeObject = (GameObject.FindGameObjectsWithTag("Respawn"));
            for (int itr = 0; itr < removeObject.Length; itr++)
            {
                Destroy(removeObject[itr]);
            }
            reset.SetActive(true);
            Time.timeScale = 0;
            gameObject.SetActive(false);
        }
    }
}
