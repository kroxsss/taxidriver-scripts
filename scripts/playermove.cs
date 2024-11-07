using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
using System.Threading.Tasks;

public class playermove : MonoBehaviour
{
    public float oilamount;
    public float speed = 0.1f;
    public Slider slider;


    private void Start()
    {
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-speed, 0, 0);

        }       
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed, 0, 0);
        }
        oilamount -= Time.deltaTime*5;
        slider.value = oilamount;
        if (oilamount <=0) 
        {
            SceneManager.LoadScene(2);


        }
    }
     async void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            
            Time.timeScale = 0;
            await Task.Delay(1000);
           SceneManager.LoadScene(2);
            Time.timeScale = 1;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oilbox")
        {
            oilamount += 10;
        }
    }
}
