using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class addZombies : MonoBehaviour
{

    public GameObject[] monster;
   
    public Button startButton;

   
    // Start is called before the first frame update
    void Start()
    {

        startButton.onClick.AddListener(ShowIt);
    }

    // Update is called once per frame


    void ShowIt()
    {

        InvokeRepeating("create", 0f, 5f);
    }

    void create()
    {

        Vector3 position = new Vector3(Random.Range(-10f,10f), 0,Random.Range(-10f,10f));
        Instantiate(monster[Random.Range(0,2)],position,Quaternion.Euler(0,0,0));
    }
}
