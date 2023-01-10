using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float fireRate = 4f;
    public float range = 100f;
    // Start is called before the first frame update
    float getFireRate()
    {
        return fireRate;
    }
    float getRange()
    {
        return range;
    }

}
