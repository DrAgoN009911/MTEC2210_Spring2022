using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        var x = Vector3.right;
        transform.Translate(Vector3.right * Time.deltaTime);
        //Hint: In unity you can get vector (direction) shorthands like this:
        //Vector3.up (etc)
    }
}
