using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 0f;
    public float fireRate = 0f;
    public float range = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        if(speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
            
        }
        else
        {
            Debug.Log("No Speed");
        }

    }
}
