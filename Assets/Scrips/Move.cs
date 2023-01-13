using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;
    private float x, y;
    void Start()
    {
        Transform parent = transform.parent;

        transform.parent = null;
        transform.localScale = new Vector2(5f, Random.Range(50, 100));
        transform.parent = parent;

        speed = 10f;
        x = -1;
        y = 0f;
    }

    void Update()
    {
        transform.position += transform.TransformDirection(new Vector2(x, y) * Time.deltaTime * speed);
        if (transform.position.x <= -80f)
        {
            Destroy(gameObject);
        }
    }
}
