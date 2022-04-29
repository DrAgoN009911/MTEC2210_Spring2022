using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
public class GameManager : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform[] carspawnpoints;
    public SpriteRenderer spriteRenderer;
    public Color[] carColors;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawncar", 3, 2);
        // Spawncar();

    }

    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetKeyDown(KeyCode.Space)) //(Get key down pressing the button)
       // {
        //    Spawncar();
       // }
        
        


    }
    // if (Input.GetKey(keycode.Space)) (holding the space button)
    // {

    //    }


    public void reloadscene()
    {
        SceneManager.LoadScene(0);
    }

    void Spawncar()
    {
    

        int index = Random.Range(0, carspawnpoints.Length);
        Vector3 spawnPos = carspawnpoints[index].position;
     GameObject car = Instantiate(carPrefab, spawnPos, Quaternion.identity);

        int dirModifier = 0;

        if(index > 2)
        {
            dirModifier = -1;
        }
        else
        {
            dirModifier = 1;
        }
        //(Another way)

        //int dirModifier = (index >2) ? -1 : 1;

        //car.GetComponent<CarMovement>().speed = Random.Range(3.0f,6.0f) * dirModifier;


        // could do this as well: Car.GetComponent<SpriteRenderer>().Color = new color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f);

        //Color colorHSV = Random.ColorHSV();
       // car.GetComponent<SpriteRenderer>().material.color = colorHSV;

        
        float newSpeed = Random.Range(3.0f, 6.9f);
        
        //car.GetComponent<CarMovement>().speed *= dirModifier; 
       

        car.GetComponent<CarMovement>().speed = newSpeed * dirModifier;

        Color c = Color.black;

        if (newSpeed < 4.0f)
        {
            c = carColors[0];

        }
        else if (newSpeed >= 4.0f && newSpeed < 5.0f)
        {
            c = carColors[1];
        }
        else if (newSpeed >= 5.0f && newSpeed < 6.0f)
        {
            c = carColors[2];
        }
        else
        {
            c = carColors[3];
        }
      
        car.GetComponent<SpriteRenderer>().color = c;


    }
}
