using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Events;

public class OnEnter : MonoBehaviour
{
    public string targetTag;
    public UnityEvent<GameObject> start;

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.tag == targetTag)
        {
            start.Invoke(other.gameObject);
        }
        */

        if (other.TryGetComponent(out XROrigin xROrigin))
        {
            Debug.Log(xROrigin + " this went through");
            start.Invoke(other.gameObject);
        }


        //start.Invoke(other.gameObject);
    }
}
