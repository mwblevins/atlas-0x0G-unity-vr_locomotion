using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public GameObject flash;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    public Animator gunAnimator;
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        gunAnimator.SetTrigger("Fire");
        GameObject spawnedBullet = Instantiate(bullet);
        GameObject muzzleFlash = Instantiate(flash);
        spawnedBullet.transform.position = spawnPoint.position;
        muzzleFlash.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(muzzleFlash, 1);
        Destroy(spawnedBullet, 5);
        

    }

    public void ResetGunAnimation()
    {
        gunAnimator.ResetTrigger("Fire");
    }
}
