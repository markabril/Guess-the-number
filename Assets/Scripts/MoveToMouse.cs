using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
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
        if (cam != null)
        {
            RaycastHit hit;
            var mousePos = Input.mousePosition;
            rayMouse = cam.ScreenPointToRay(mousePos);
            if (Physics.Raycast(rayMouse.origin, rayMouse.direction, out hit))
            {
                Debug.Log(hit);
                moveToMousePosition(gameObject, hit.point);
            }
        }
        else
        {
            Debug.Log("No Camera");
        }
    }


    void moveToMousePosition(GameObject obj, Vector3 destination)
    {
        obj.transform.position = destination;
    }
}
