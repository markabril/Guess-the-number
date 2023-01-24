using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandleLeft : MonoBehaviour
{
    public GameObject LeftHandTarget;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position = LeftHandTarget.transform.position;
    }
}
