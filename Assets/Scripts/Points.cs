using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameObject restartButton;
    public Text scoreText;
    public Text GameOver;
    int puan;

    //    public float trigger;
    //    Rigidbody rb;
    //    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + puan;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Puan250"))
        {
            puan += 250;
        }
        else if (collision.gameObject.CompareTag("Puan500"))
        {
            puan += 500;
        }
        else if (collision.gameObject.CompareTag("Puan100"))
        {
            puan += 100;
        }

        //    if (collision.gameObject.CompareTag("RedStick"))
        //    {
        //      rb.AddForce(0, 0, trigger); 
        //    }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            GameOver.gameObject.SetActive(true);    
            scoreText.gameObject.SetActive(false);
            restartButton.gameObject.SetActive(true);

        }

    }
}
