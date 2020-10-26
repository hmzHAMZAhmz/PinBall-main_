using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    private bool GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameOver"))
        {
            GameOver = true;






        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("Arena1");

    }

}
