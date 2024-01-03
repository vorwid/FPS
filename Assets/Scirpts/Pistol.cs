using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Pistol : MonoBehaviour
{
    public Sprite idlePistol;
    public Sprite shotPistol;
    public float pistolDamage;
    public float pistolRange;
    public AudioClip shotSound;
    public AudioClip reloadSound;
    public AudioClip emptyGunSound;
    AudioSource source;

    public Text ammoText;

    public int ammoAmount;
    public int ammoClipSize;

    int ammoLeft;
    int ammoClipLeft;

    bool isShot;
    bool isReloading;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        ammoLeft = ammoAmount;
        ammoClipLeft = ammoClipSize;
    }

    void Update()
    {
        ammoText.text = ammoClipLeft + " / " + ammoLeft;

        if(Input.GetButtonDown("Fire1"))
            isShot = true;
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(isShot == true && ammoClipLeft > 0 && isReloading == false)
        {
            isShot = false;
            ammoClipLeft--;
            source.PlayOneShot(shotSound);
            StartCoroutine("shot");
            if(Physics.Raycast(ray, out hit, pistolRange))
            {
                Debug.Log("Wszedlem w kolizje z " + hit.collider.gameObject.name);
                hit.collider.gameObject.SendMessage("pistolHit", pistolDamage, SendMessageOptions.DontRequireReceiver);
            }
        } else if (isShot == true && ammoClipLeft <= 0 && isReloading == false)
        {
            isShot = false;
            Reload();
        }
    }

    void Reload()
    {
        int bulletToReload = ammoClipSize - ammoClipLeft;
        if(ammoLeft >= bulletToReload)
        {
            StartCoroutine("ReloadWeapon");
            ammoLeft -= bulletToReload;
            ammoClipLeft  = ammoClipSize;
        } else if (ammoLeft < bulletToReload && ammoLeft > 0)
        {
            ammoClipLeft += ammoLeft;
            ammoLeft = 0;
        } else if ( ammoLeft <= 0)
        {
            source.PlayOneShot(emptyGunSound);
        }
    }

    IEnumerator ReloadWeapon()
    {
        isReloading = true;
        source.PlayOneShot(reloadSound);
        yield return new WaitForSeconds(2);
        isReloading = false;
    }

    IEnumerator shot()
    {
        GetComponent<SpriteRenderer>().sprite = shotPistol;
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().sprite = idlePistol;
    }
}
