using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Control1 : MonoBehaviour
{

    public GameObject blood;
    public Text healthText;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(bool active)
    {

        blood.gameObject.SetActive(true);

        StartCoroutine(wait());

        health -= 2;

        if (health == 0)
        {

            SceneManager.LoadScene("YOU LOST");
        }


        string stringHealth = (health).ToString();
        healthText.text = "" + stringHealth;

       

        
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        blood.gameObject.SetActive(false);


    }
}
