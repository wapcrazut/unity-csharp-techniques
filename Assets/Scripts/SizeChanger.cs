using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour, IInteractable
{
    void ChangeSize()
    {
        transform.localScale = Vector3.one * 2 * Random.value;
    }

    public void Interact()
    {
        ChangeSize();
    }
}
