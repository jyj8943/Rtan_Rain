using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    private float direction = 0.05f;

    private SpriteRenderer renderer;
    
    void Start()
    {
        Application.targetFrameRate = 60;
        renderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }
        
        if (transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            direction = -0.05f;
        }

        if (transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            direction = 0.05f;
        }
        
        transform.position += Vector3.right * direction;
    }
}
