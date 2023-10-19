using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowandArrow : MonoBehaviour
{
    
    public GameObject arrow;

    //arrow force
    public float shootForce, upwardForce;

    //arrow stats
    public float timeBetweenShooting, spread, reloadTime, timeBetweenShots;
    public int quiverSize, arrowPerTap;
    public bool allowButtonHold;

    int arrosLeft, arrowsShot;

    bool shooting, readyToShoot, reloading;

    public Camera playerCam;
    public Transform attackPoint;

    public bool allowInvoke = true;

    private void Awake()
    {
        //making sure that the quiver is full
        arrosLeft = quiverSize;
        readyToShoot = true; 
    }
    private void Update()
    {
        MyInput(); 
    }
    private void MyInput()
    {
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        //Reloading 
        if (Input.GetKeyDown(KeyCode.R) && arrosLeft < quiverSize && !reloading) Reload();
        // Automatically reloading if you do not have any arrows left
        if (readyToShoot && shooting && !reloading && arrosLeft <= 0) Reload(); 

        //Shooting
       if(readyToShoot && shooting && !reloading && arrosLeft > 0)
        {
            arrowsShot = 0;

            Shoot(); 
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        // Finding the exact hit postion using a raycast
        Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        //Checking to see if the Raycast has hit something
        Vector3 targetPoint; 
        if(Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point; 
        }
        else
        {
            targetPoint = ray.GetPoint(75); // a point that is away from the player
        }

        //Calculate direction from attackPoint to TargetPoint
        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculating new direction with the spread
        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0);

        //spawning the arrow 
        GameObject currentArrow= Instantiate(arrow, attackPoint.position, Quaternion.identity);

        //rotation the arrow in the direction player wants to shoot 
        currentArrow.transform.position = directionWithSpread.normalized;

        //adding force to the arrow 
        currentArrow.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
        currentArrow.GetComponent<Rigidbody>().AddForce(playerCam.transform.up * upwardForce, ForceMode.Impulse); 

        arrosLeft--;
        arrowsShot++;

        //Invoke a resetShot function
        Invoke("ResetShot", timeBetweenShooting);
        allowInvoke = false; 

        //When more then one arrow is shot 
        if (arrowsShot < arrowPerTap && arrosLeft > 0)
        {
            Invoke("Shoot", timeBetweenShots);
        }

    }

    private void ResetShot()
    {
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
        arrosLeft = quiverSize;
        reloading = false; 
    }


}
