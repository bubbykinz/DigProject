using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public AudioClip chestSound;
    AudioSource audioSource;

    bool alreadyHit;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        alreadyHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (alreadyHit == false)
            {
                Debug.Log("chest hit");
                audioSource.PlayOneShot(chestSound, 0.75f);
                spriteRenderer.sprite = newSprite;
                alreadyHit = true;
            }
        }
    }
}
