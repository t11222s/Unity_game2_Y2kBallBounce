using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarsMoveScript : MonoBehaviour
{
    public GameObject pillar;
    public float appearRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        appearSpawn();

    }

    // Update is called once per frame
    void Update()
    {
         if (timer < appearRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            appearSpawn();
                timer = 0;
        }
    }
    void appearSpawn()
    {
        /* Instantiate(pillar, transform.position, transform.rotation);*/
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pillar, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
