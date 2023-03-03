using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) *Time.deltaTime ; 
        //deltatime for non-phy.(not for velocity...)
        if (transform.position.x < deadzone)
        {
            //Debug.log("PillarErased");
            Destroy(gameObject);
        }

    }
}
