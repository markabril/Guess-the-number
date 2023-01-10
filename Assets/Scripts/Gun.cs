using UnityEngine;

public class Gun : MonoBehaviour
{

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;


    public float range = 100f;
    public float damage = 10f;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Shoot();
        //}
    }

    public void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){

            Debug.Log(hit.transform.name);

        }
    }
}
