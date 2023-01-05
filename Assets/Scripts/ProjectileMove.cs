using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 0f;
    public float fireRate = 0f;
    public float range = 10;
    // Start is called before the first frame update

    private Vector3 currentPosition;
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
            if (Vector3.Distance(currentPosition, transform.position) > range)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            Debug.Log("No Speed");
        }
        
    }
}
