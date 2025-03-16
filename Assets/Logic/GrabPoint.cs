using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabPoint : MonoBehaviour
{
   static public GameObject grabedObj;
    void Update()
    {
       if (grabedObj != null) if(grabedObj.GetComponent<Rigidbody>())  grabedObj.GetComponent<Rigidbody>().linearVelocity = -(grabedObj.transform.position-transform.position)*2;
    }
}
