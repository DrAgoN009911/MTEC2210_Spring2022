using System.Collections;
using System.Collections.Generic;
using UnityEngine;






[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer != null)
        {
            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value
                );

            spriteRenderer.color = newColor;
        }

    }
}
