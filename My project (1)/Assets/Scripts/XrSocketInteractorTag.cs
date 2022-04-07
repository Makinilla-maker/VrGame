using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XrSocketInteractorTag : XRSocketInteractor
{
    public string targetTag;
    public bool realoaded = false;

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        if(!realoaded) 
        {
            //realoaded = true;
            return base.CanSelect(interactable) && interactable.CompareTag(targetTag);
        }
        else
        {
            return false;
        } 
            
    }
    
}
