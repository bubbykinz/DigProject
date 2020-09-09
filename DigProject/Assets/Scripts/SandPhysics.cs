using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandPhysics : MonoBehaviour
{
    public bool appliedVelocity = false;
    public Rigidbody2D rigidBody2D;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    public void ApplyVelocity()
    {
        if (gameObject != null)
        {
            gameObject.layer = LayerMask.NameToLayer("FreeFly");
        }
        rigidBody2D.constraints = RigidbodyConstraints2D.None;
        this.rigidBody2D.velocity = new Vector2(10, 20);
        this.appliedVelocity = true;
        
    }
    public void ApplyDefault()
    {
        rigidBody2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        this.rigidBody2D.velocity = Vector2.zero;
        this.appliedVelocity = false;
        gameObject.layer = LayerMask.NameToLayer("Dirt");
    }

        //Update is called once per frame
        void Update()
        {
            if (rigidBody2D.velocity == new Vector2(1, 1))
            {
           ApplyDefault();
            }
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name == "Shovel")
            {   
            ApplyVelocity();
            }
                
        }
    }

