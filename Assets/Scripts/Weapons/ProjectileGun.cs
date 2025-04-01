using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class ProjectileGun : MonoBehaviour
{
    //Bullet game object [prefab TBC]
    public GameObject bullet;

    //Force of the bullet
    public float shootForce;
    public float upwardForce;

    //Gun Stats
    public float timeBetweenShooting;
    public float spread;
    public float reloadTime;
    public float timeBet;
    public int magazineSize;
    public int bulletsPerShot;
    public bool allowButtonHold;
    int bulletsLeft;
    int bulletsShot;

    //Boolean variables
    bool shooting;
    bool readyToShoot;
    bool reloading;

    //References in scene
    public Camera fpsCam;
    public Transform attackPoint;

    //Testing
    public bool allowInvoke = true;

    //Graphics
    public TextMeshProUGUI ammoDisplay;

    private void Awake()
    {
        //Full ammo and ability to shoot set
        bulletsLeft = magazineSize;
        readyToShoot = true;
    }

    private void Update()
    {
        MyInput();

        //Set ammo display 
        if (ammoDisplay != null)
        {
            ammoDisplay.SetText(bulletsLeft + " / " + magazineSize);
        }
    }

    private void MyInput()
    {
        ////Check if you can hold the button for shooting
        //if (allowButtonHold)
        //{
        //    //shooting = Input.GetKey(KeyCode.Mouse0);
        //    shooting = Input.GetButton("Fire1");
        //}
        //else
        //{
        //    shooting = Input.GetButtonDown("Fire1");
        //    //shooting = Input.GetKeyDown(KeyCode.Mouse0);
        //}

        shooting = Input.GetButtonDown("Fire1");

        //Reloading
        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading)
        {
            Reload();
        }

        //Reload automatically
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            Reload();
        }

        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            //Set bullets shot to 0
            bulletsShot = 0;

            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        //Find the exact hit position using a raycast
        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //Hit point tends to be middle of screen
        RaycastHit hit;

        //Check if the ray is hitting something
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        else
        {
            targetPoint = ray.GetPoint(75); //Point away from the player
        }

        //Calculate direction from attack point to target point
        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        //Calculate spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);
        float z = Random.Range(-spread, spread);

        //Calculate new direction with spread
        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, z); //0 use to be Z

        //Instantiate bullet
        //GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);
        GameObject currentBullet = Instantiate(bullet, attackPoint.position, attackPoint.rotation);

        //Roate bullet to shoot direction
        //currentBullet.transform.forward = directionWithSpread.normalized;

        //Add forces to bullet
        //currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
        //currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);
        // Get the Rigidbody component and apply force to shoot the bullet forward
        Rigidbody rb = currentBullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(attackPoint.forward * shootForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Projectile does not have a Rigidbody component.");
        }

        bulletsLeft--;
        bulletsShot++;

        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;
        }

        if(bulletsShot < bulletsPerShot && bulletsLeft > 0)
        {
            Invoke("Shoot", timeBetweenShooting);
        }
    }

    private void ResetShot()
    {
        //Allow shooting and invoking
        readyToShoot = true;
        allowInvoke = true;
    }

    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime);
    }

    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }
}
