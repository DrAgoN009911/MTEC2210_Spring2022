using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GameManager : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform[] carspawnpoints;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Spawncar();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //(Get key down pressing the button)
        {
            Spawncar();
        }
        
        


    }
    // if (Input.GetKey(keycode.Space)) (holding the space button)
    // {

//    }


    void Spawncar()
    {
    

        int index = Random.Range(0, carspawnpoints.Length);
        Vector3 spawnPos = carspawnpoints[index].position;
     GameObject car = Instantiate(carPrefab, spawnPos, Quaternion.identity);

        //int dirModifier = 1;

       // if(index > 2)
      //  {
        //    dirModifier = -1;
        //}
        //(Another way)

        int dirModifier = (index >2) ? -1 : 1;

        car.GetComponent<CarMovement>().speed = Random.Range(3.0f,6.0f) * dirModifier;

        Color colorHSV = Random.ColorHSV();
        car.GetComponent<SpriteRenderer>().material.color = colorHSV;

        car.GetComponent<CarMovement>().speed *= dirModifier;

        

    }
}
