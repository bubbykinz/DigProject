using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public GameObject shovel;
    public float colW;
    public float colH;
    private float prevMovement = 0f;
    public float shoveltime = 1f;
    public float stimer = 0f;

    public float moveSpeed = 5f;
    public float jumpSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (stimer > 0)
        {
            stimer -= Time.deltaTime;
            if (stimer <= 0)
            {
                shovel.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
       
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        float rot = this.transform.localRotation.eulerAngles.y;
        if (movement.x > 0)
        {
            rot = 0f;
        }
        else if (movement.x < 0)
        {
            rot = 180f;
        }
        Vector3 rotation = this.transform.localRotation.eulerAngles;
        this.transform.rotation = Quaternion.Euler(rotation.x, rot, rotation.z);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.rigidBody != null)
                this.rigidBody.velocity += new Vector2(0f, jumpSpeed);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            shovel.GetComponent<BoxCollider2D>().enabled = true;
            stimer = shoveltime;
        }
    }


}
