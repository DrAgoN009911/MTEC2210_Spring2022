using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public float speed = 5.0f;
    public GameManager gameManager;
    private AudioSource audioSource;

    public AudioClip hopClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;


        transform.Translate(xMovement, yMovement, 0);
        //audioSource.clip = hopClip;
        if (xMove != 0 || yMove != 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {

            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            // could say this transform.position = new Vector3(transform.position.x + xMovement, transform.positiony + yMovement, transform.position.Z);
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("Area cleared");
            gameManager.reloadscene();
        }

    }
    


    

}

    
