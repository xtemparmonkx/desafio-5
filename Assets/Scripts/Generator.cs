using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float DelayShot = 2f;
    public float IntervalShot = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", DelayShot, IntervalShot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        Instantiate (BulletPrefab, transform);
    }

}
