using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandleRight : MonoBehaviour
{
    public GameObject RightHandTarget;


    // Update is called once per frame
    void Update()
    {
        transform.position = RightHandTarget.transform.position;        
    }
}
