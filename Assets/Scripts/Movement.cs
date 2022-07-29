using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 2f;
    public float livetime = 3f;
    void Start()
    {
        Invoke ("DestroyDelay", livetime);
    }

    // Update is called once per frame
    void Update()
    {
        {
            Move();
        }

        {
            if (Input.GetKeyDown(KeyCode.Space))
                transform.localScale = transform.localScale * 2;
        }
    }

    private void DestroyDelay()
    {
        Destroy(gameObject);
    }

    private void Move()
    {
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
