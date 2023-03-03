using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;//reference

    public float flapStrength;
        public logicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update() { 
    
        if(Input.GetKeyDown(KeyCode.RightShift) == true && birdIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
    }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverS();
        birdIsAlive = false;
    }

}
