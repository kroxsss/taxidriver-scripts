using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_move : MonoBehaviour
{
    public float roadspeed;
    public Vector3 newroadpos;

    void Update()
    {
            transform.Translate(roadspeed*Time.deltaTime,0,0);
        if (transform.localPosition.x < -21.34)
        {
            gameObject.transform.localPosition = newroadpos;
        }
           

    }
}
