using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantMoving : MonoBehaviour
{

    public bool active;

    float t;

    float secondsTillAttack;

    AudioSource StrikeSound;

 

    public Control1 control;

    // Start is called before the first frame update
    void Start()
    {
        secondsTillAttack = 0.5f;

        GameObject controlGameObject = GameObject.FindWithTag("Controller");

        if(controlGameObject != null)
        {

            control = controlGameObject.GetComponent<Control1>();
        }

        AudioSource[] audioSourcess = GetComponents<AudioSource>();

        StrikeSound = audioSourcess[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 0.5f);
        transform.LookAt(Camera.main.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        t += Time.deltaTime;

        if(active && t>=secondsTillAttack)
        {

 

            Attack();
        }

    }




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {

            Debug.Log("sds");
            active = true;

        


        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Debug.Log("Tag");
            active = false;
        }

    }

        void Attack()
        {
            t = 0f;

            GetComponent<Animator>().Play("attack");

        control.Attack(active);

        StrikeSound.Play();
       

        }


    }
