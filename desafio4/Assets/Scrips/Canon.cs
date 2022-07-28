using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                ShootTwo();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    ShootThree();
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.L))
                    {
                        ShootFour();
                    }
                }
            }
        }
    }
    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
    private void ShootTwo()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
    private void ShootThree()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Invoke("Shooting", 1f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1.5f);
        }
    }
    private void ShootFour()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("Shooting", 0.5f);
            Invoke("Shooting", 1f);
            Invoke("Shooting", 1.5f);
            Instantiate(munition, transform);
            Invoke("ResetShoot", 2f);
        }
    }
    private void ResetShoot()
    {
        canShoot = true;
    }
    private void Shooting()
    {
        Instantiate(munition, transform);
    }
}
