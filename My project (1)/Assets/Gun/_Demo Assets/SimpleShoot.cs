using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Nokobot/Modern Guns/Simple Shoot")]
public class SimpleShoot : MonoBehaviour
{
    [Header("Prefab Refrences")]
    public GameObject bulletPrefab;
    public GameObject fakeBulletPrefab;
    public GameObject patitoPrefab;
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;

    [Header("Bullets Section")]
    public int totalBullets;
    private int shootedBullets = 0;

    [Header("Location Refrences")]
    [SerializeField] private Animator gunAnimator;
    [SerializeField] private Transform barrelLocation;
    [SerializeField] private Transform casingExitLocation;

    [Header("Settings")]
    [Tooltip("Specify time to destory the casing object")] [SerializeField] private float destroyTimer = 2f;
    [Tooltip("Bullet Speed")] [SerializeField] private float shotPower = 0.1f;
    [Tooltip("Casing Ejection Speed")] [SerializeField] private float ejectPower = 50f;

    public AudioSource source;
    public AudioClip fireSound;
    public int bulletsInSceneInt = 0;
    public List<GameObject> bulletsInScene = new List<GameObject>();
    public List<GameObject> bulletSocket = new List<GameObject>();
    public Animation reloadAnimation;
    public GameObject duck;
    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;

        if (gunAnimator == null)
            gunAnimator = GetComponentInChildren<Animator>();

            for(int i = 0; i < 6; i++)
            {
                bulletsInScene.Add(bulletPrefab);
                Instantiate(fakeBulletPrefab, bulletSocket[i].transform.position, bulletSocket[i].transform.rotation, bulletSocket[i].transform);
            }
    }

    public void PullTheTrigger()
    {
        gunAnimator.SetTrigger("Fire");
    }

    //This function creates the bullet behavior
    public void Shoot()
    {
        if(shootedBullets == totalBullets-1)
        {
            gunAnimator.SetBool("reload", true);
            gunAnimator.SetBool("reloaded", false);
        }
        if(shootedBullets<totalBullets)
        {
            Debug.Log("a");
            source.PlayOneShot(fireSound);
            if (muzzleFlashPrefab)
            {
            ////Create the muzzle flash
            //    GameObject tempFlash;
            //    tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);

            //Destroy the muzzle flash effect
            //Destroy(tempFlash, destroyTimer);
            }

            //cancels if there's no bullet prefeb
            if (!bulletPrefab)
            { return; }

            // Create a bullet and add force on it in direction of the barrel
            if(!duck.GetComponent<IsDuckConected>().duck)
            {
                Instantiate(bulletsInScene[bulletsInSceneInt], barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
                bulletSocket[bulletsInSceneInt].SetActive(false);
                bulletsInSceneInt++;

                Debug.Log(bulletsInSceneInt);
            }
            else    Instantiate(patitoPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
            shootedBullets++;
        }
    }

    public void Reload()
    {
        Debug.Log("Reloading");
    }
    //This function creates a casing at the ejection slot
    void CasingRelease()
    {
        //Cancels function if ejection slot hasn't been set or there's no casing
        if (!casingExitLocation || !casingPrefab)
        { return; }

        //Create the casing
        GameObject tempCasing;
        tempCasing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        //Add force on casing to push it out
        tempCasing.GetComponent<Rigidbody>().AddExplosionForce(Random.Range(ejectPower * 0.7f, ejectPower), (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        //Add torque to make casing spin in random direction
        tempCasing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(100f, 1000f)), ForceMode.Impulse);

        //Destroy casing after X seconds
        Destroy(tempCasing, destroyTimer);
    }

}
