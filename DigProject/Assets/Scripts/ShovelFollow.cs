using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelFollow : MonoBehaviour
{
    public GameObject objectToFollow;

   //public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position;
    }

}
