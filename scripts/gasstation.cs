using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasstation : MonoBehaviour
{
    public float maxtime = 1;
    public float timer = 0;
    public GameObject gas;
    public float pump;
    void Start()
    {
        GameObject newgas = Instantiate(gas);
        newgas.transform.position = transform.position + new Vector3(0, Random.Range(-pump, pump), 0);
    }

    void Update()
    {
        if (timer > maxtime)
        {

            GameObject newgas = Instantiate(gas);
            newgas.transform.position = transform.position + new Vector3(0, Random.Range(-pump, pump), 0);
            Destroy(newgas, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    

}
