using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Collider2D shovel;
    public float colW;
    public float colH;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.rigidBody != null)
                this.rigidBody.velocity += new Vector2(0f, jumpSpeed);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (this.shovel != null)
            {
                Collider[] array = Physics.OverlapBox(this.shovel.transform.localPosition, new Vector3(colW, colH, 0f));
                foreach ( Collider in array) ;
            }



            object GetComponent(SandPhysics.GameOb
        }
    }
}
