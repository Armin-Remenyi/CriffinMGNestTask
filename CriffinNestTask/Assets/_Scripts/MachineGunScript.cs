using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunScript : MonoBehaviour
{
    //public Transform spawnPoint;
    //public float distance = 15f;

    //public GameObject muzzleFlash;
    //public GameObject impact;

    //Camera camera;
    //bool isFiring;

    //float shotCounter;
    //public float rateOfFire = 0.1f;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    camera = Camera.main;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //Shoot input;
    //    if (Input.GetButtonDown("Firel"))
    //        isFiring = true;
    //    else if (Input.GetButtonUp("Firel"))
    //        isFiring = false;

    //    if (isFiring)
    //    {
    //        shotCounter -= Time.deltaTime;

    //        if (shotCounter <= 0)
    //        {
    //            shotCounter = rateOfFire;
    //            Shoot();
    //        }
    //        else
    //            shotCounter -= Time.deltaTime;
    //    }
    //}

    ////Method to shoot;
    //void Shoot()
    //{
    //    RaycastHit hit;

    //    GameObject muzzleInst = Instantiate(muzzle, spawnPoint.position, spawnPoint.rotation);
    //    muzzleInst.transform.parent = spawnPoint;

    //    if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
    //    {
    //        Debug.Log("Hit");

    //        Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
    //    }
    //    else
    //        Debug.Log("No Hit");
    //}

    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public AudioSource audioSource;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    private float nextTimeToFire = 0f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            audioSource.Play();

            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            //AIMove target = hit.transform.GetComponent<AIMove>();
            //if (target != null)
            //{
            //    target.TakeDamage(damage);
            //}
        }
    }
}
