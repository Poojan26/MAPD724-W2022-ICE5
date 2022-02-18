using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float verticalSpeed;
    public Boundary boundary; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
        CheckBounds();
    }

    public void Move()
    {
        Vector2 currentPosition = transform.position;
        currentPosition += new Vector2(0.0f,verticalSpeed);
        transform.position = currentPosition;
    }

    public void CheckBounds()
    {
        if(transform.position.y < boundary.bottom)
        {
            ResetObject();
        }
    }

    public void ResetObject()
    {
        transform.position = new Vector2(0.0f,boundary.top); 
    }
}
