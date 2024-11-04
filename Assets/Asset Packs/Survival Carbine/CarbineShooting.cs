using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbineShooting : MonoBehaviour
{
    public Transform originTransform;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = new Ray(originTransform.position, originTransform.forward);
            RaycastHit hit;

             Debug.DrawRay(originTransform.position, originTransform.forward * 100f, Color.red, 2f);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                Debug.Log("I hit an object: " + hit.collider.name);
            }
        }
    }
}
