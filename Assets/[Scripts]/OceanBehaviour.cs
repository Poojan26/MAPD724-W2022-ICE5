using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float verticalSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    public void Move()
    {
        transform.position = transform.position + new Vector2(0.0f,verticalSpeed);
    }
}
