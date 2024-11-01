using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float magnesConst = 0.005f;
    public float dragConst = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddRelativeForce(MagnesForce());
        GetComponent<Rigidbody>().AddRelativeForce(AirForce());
    }

    private Vector3 AirForce()
    {
        float velocityMag = GetComponent<Rigidbody>().velocity.magnitude;
        Vector3 velocityDir = GetComponent<Rigidbody>().velocity.normalized;
        float airDragMag = dragConst * Mathf.Pow(velocityMag, 2f);
 
        return airDragMag * -velocityDir;
    }

    private Vector3 MagnesForce()
    {
        Vector3 magnesForce = magnesConst * Vector3.Cross(GetComponent<Rigidbody>().velocity, GetComponent<Rigidbody>().angularVelocity);
        return magnesForce;
    }
}
