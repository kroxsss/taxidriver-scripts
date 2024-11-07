using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float maxtime =1;
    public float timer = 0;
    public GameObject bullet ;
    public float gun_barrel;
    public List<Sprite> cars=new List<Sprite>();
    void Start()
    {
        GameObject newbullet=Instantiate(bullet);
        newbullet.transform.position = transform.position+new Vector3(0,Random.Range(-gun_barrel,gun_barrel),0);
        
    }

    void Update()
    {
        if (timer > maxtime)
        {

            GameObject newbullet = Instantiate(bullet);
           SpriteRenderer spriteRenderer = newbullet.GetComponent<SpriteRenderer>();
            int carsindex=Random.Range(0,cars.Count);
            spriteRenderer.sprite = cars[carsindex];
            newbullet.transform.position = transform.position + new Vector3(0, Random.Range(-gun_barrel, gun_barrel), 0);
            Destroy(newbullet,5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
