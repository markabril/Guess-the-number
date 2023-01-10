using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    // Start is called before the first frame update
    private readonly float projectileSpeed = 1000;
    private Vector3 currentPosition;
    void Start()
    {
        currentPosition = transform.position;
    }


    void Update()
    {
        transform.position += transform.forward * (projectileSpeed * Time.deltaTime);
        if (Vector3.Distance(currentPosition, transform.position) > 100f)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
}
