using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class viewTouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool _isDragging;
    private RectTransform _rect;
    private Transform PlayerCamera;

    public Transform PlayerBody;
    public Transform weaponBody;

    //float xRotation = 0f;

    public float mouseSensitivity = .5f;
    public void OnPointerDown(PointerEventData eventData)
    {

        _isDragging = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _isDragging = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        _rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!_isDragging)
            return;

        Debug.Log("Debugging");
        //PlayerCamera = PlayerBody.GetChild(1).GetComponent<Transform>();
        //float mouseX = 0;
        //float mouseY = 0;
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    mouseX = Input.GetTouch(0).deltaPosition.x * mouseSensitivity;
        //    mouseY = Input.GetTouch(0).deltaPosition.y * mouseSensitivity;
        //}
        //xRotation -= mouseY * Time.deltaTime;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        //PlayerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //PlayerBody.Rotate(mouseX * Time.deltaTime * Vector3.up);
        //weaponBody.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
