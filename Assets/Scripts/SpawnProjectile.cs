using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FirePoint;
    public GameObject Player;
    public List<GameObject> Projectiles = new List<GameObject>();
    public List<GameObject> MuzzleFlashes = new List<GameObject>();
    public List<GameObject> Weapons = new List<GameObject>();


    public int useProjectile = 0;
    public int useMuzzleFlash = 0;
    public int useWeapon = 0;


    private GameObject projectile;
    private GameObject muzzleflash;
    private Weapon weapon;

    public Camera fpsCam;
    GameObject muzzle;
    private bool canFire = true;
    void Start()
    {
        projectile = Projectiles[useProjectile];
        muzzleflash = MuzzleFlashes[useMuzzleFlash];
        weapon = Weapons[useWeapon].GetComponent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            if (canFire)
            {
                StartCoroutine(Fire());
            }
            
        }
    }


    IEnumerator Fire()
    {
        canFire = false;
        muzzle = Instantiate(muzzleflash, FirePoint.transform.position, Quaternion.identity);
        muzzle.transform.localRotation = Quaternion.Euler(fpsCam.transform.localRotation.eulerAngles.x, Player.transform.localRotation.eulerAngles.y, 0);
        ParticleSystem PSMuzzle = muzzle.GetComponentInChildren<ParticleSystem>();
        SpawnVFX();
        Destroy(muzzle, PSMuzzle.main.duration);
        StartCoroutine(FireRateHandler());
        yield return null;
    }

    IEnumerator FireRateHandler()
    {
        float timeToNextFire = 1f / weapon.fireRate;
        yield return new WaitForSeconds(timeToNextFire);
        canFire = true;
    }
    void SpawnVFX()
    {
        GameObject vfx;
        Vector3 InitialPosition;
        

        if (FirePoint != null)
        {

            vfx = Instantiate(projectile, FirePoint.transform.position, Quaternion.identity);
            InitialPosition = vfx.transform.position;
            if (fpsCam != null)
            {
                vfx.transform.localRotation = Quaternion.Euler(fpsCam.transform.localRotation.eulerAngles.x, Player.transform.localRotation.eulerAngles.y, 0);
                
            }

        }
        
    }
}

