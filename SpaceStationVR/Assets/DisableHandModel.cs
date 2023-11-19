using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectEntered.AddListener(ShowGrabbingHand);

    }

    public void ShowGrabbingHand(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }
}
