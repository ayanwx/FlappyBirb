using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnSpeed = 3f;
    public float timer;

    public float heightOffset = 5f;

    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnSpeed)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        float randomPoint = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, randomPoint, transform.position.z), transform.rotation);
    }
}
