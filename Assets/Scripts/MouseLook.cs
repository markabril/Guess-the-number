using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 1f;
    public Transform PlayerBody;
    public Transform weaponBody;


    float xRotation = 0f;
    float mouseAdjSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouseAdjSensitivity = mouseSensitivity * Time.deltaTime * 10000;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseAdjSensitivity ;
        float mouseY = Input.GetAxis("Mouse Y") * mouseAdjSensitivity ;

        xRotation -= mouseY * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX * Time.deltaTime);
        weaponBody.transform.position = this.transform.position;
       
        weaponBody.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
