using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
    public AudioSource ASDS;

 
    public Button shootBtn;

    public GameObject animationForgun;
    public Camera fpsCam;
    public float damage = 10f;
    public ParticleSystem fpsParticle;

    public GameObject DamageEffect;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audio = GetComponents<AudioSource>();

        ASDS = audio[0];
        shootBtn.onClick.AddListener(onShoot);

    }

    void onShoot()
    {

        ASDS.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {

            Monster1 target = hit.transform.GetComponent<Monster1>();

            if (target != null)
            {
                target.damage1(damage);
            }

           

            
        }
        fpsParticle.Play();

        animationForgun.GetComponent<Animator>().Play("Fire1shot");
    }

}
