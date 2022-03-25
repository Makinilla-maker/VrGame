using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomMultipleInteractable : XRBaseInteractable
{
    private MaterialApplier materialApllier;
    private Transform transforms;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        materialApllier = GetComponent<MaterialApplier>();
    }
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        if(HasMultipleInteractors())
        {
            materialApllier.ApplyOther();
        }
        
    }
    private bool HasMultipleInteractors()
    {
        return interactorsSelecting.Count > 1;
    }
    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        base.OnSelectExiting(args);

        if(HasNoInteractors())
        {
            materialApllier.ApplyOriginal();
        }
    }
    private bool HasNoInteractors()
    {
        return interactorsSelecting.Count == 0;
    }
}
