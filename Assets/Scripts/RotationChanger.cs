using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationChanger : MonoBehaviour, IInteractable
{
    void ChangeRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, Random.value * 50);
    }

    public void Interact()
    {
        ChangeRotation();
    }
}
