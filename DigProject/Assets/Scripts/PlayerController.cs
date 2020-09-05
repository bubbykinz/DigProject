using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float moveSpeed = 5f;
    public float jumpSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (this.rigidBody != null)
                this.rigidBody.velocity += new Vector2(0f, jumpSpeed);
        }
    }
}
