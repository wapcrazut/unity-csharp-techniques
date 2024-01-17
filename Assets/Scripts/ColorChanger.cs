using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour, IInteractable
{
    SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Interact()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        sr.color = new Color(Random.value, Random.value, Random.value);
    }
}
