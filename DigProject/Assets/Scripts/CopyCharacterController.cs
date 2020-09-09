using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class CopyCharacterController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Collider2D shovel;
    public float colW;
    public float colH;

    public float moveSpeed = 5f;
    public float jumpSpeed = 5f;

    public SpriteRenderer spriteRenderer;

    public BoxCollider2D[] boxColliders;

    //public Transform ColliderTransform;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        boxColliders = GetComponentsInChildren<BoxCollider2D>();
        //Collider collider = ColliderTransform.GetChild(0).GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = true;
            boxColliders[2].enabled = true;
            boxColliders[1].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = false;
            boxColliders[1].enabled = true;
            boxColliders[2].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.rigidBody != null)
                this.rigidBody.velocity += new Vector2(0f, jumpSpeed);
        }
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    if (other.gameObject.tag == "sand")
        //    {
        //        Debug.Log("sand detected");
        //        if (Input.GetKeyDown(KeyCode.R))
        //        {
        //            other.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 500));
        //        }
        //    }
        //}

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (this.shovel != null)
            {
                Collider[] array = Physics.OverlapBox(this.shovel.transform.localPosition, new Vector3(colW, colH, 0f));
                //foreach (Collider in array) ;
            }



            //object GetComponent(SandPhysics.GameOb
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "sand")
        {
            Debug.Log("sand detected");
            if (Input.GetKeyDown(KeyCode.R))
            {
                other.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            }
        }
    }

}
