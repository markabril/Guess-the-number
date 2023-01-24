using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{

    public Camera cam;
    public float maximumLength;

    private Ray rayMouse;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam != null)
        {
            RaycastHit hit;
            var mousePos = Input.mousePosition;
            rayMouse = cam.ScreenPointToRay(mousePos);
            if(Physics.Raycast(rayMouse.origin, rayMouse.direction, out hit))
            {
                Debug.Log(hit);
                RotateToMouseDirection(hit.point);
            }
        }
        else
        {
            Debug.Log("No Camera");
        }
    }

    void RotateToMouseDirection(Vector3 destination )
    {
        transform.position = destination;
    }

    public Quaternion GetRotation()
    {
        return rotation;
    }

}
