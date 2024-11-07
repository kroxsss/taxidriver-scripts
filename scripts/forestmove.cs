using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestmove : MonoBehaviour
{
    public float forestspeed;
    public Vector3 newforestpos;

    void Update()
    {
        transform.Translate(forestspeed * Time.deltaTime, 0, 0);
        if (transform.localPosition.x < -44.24)
        {
            gameObject.transform.localPosition = newforestpos;
        }


    }
}
