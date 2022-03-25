using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialApplier : MonoBehaviour
{
    [SerializeField] private Material originalMaterial;
    [SerializeField] private Material otherMaterial;

    // Start is called before the first frame update
    public void ApplyOriginal()
    {
        ApplyMaterial(originalMaterial);
    }
    public void ApplyOther()
    {
        ApplyMaterial(otherMaterial);
    }
    private void ApplyMaterial(Material newMaterial)
    {
        if(TryGetComponent(out MeshRenderer meshRenderer))
        {
            meshRenderer.material = newMaterial;
        }
    }
}
