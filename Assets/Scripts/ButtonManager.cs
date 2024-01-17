using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button button;
    int gold;

    private void Start()
    {
        // Use lambda to send parametes to function
        button.onClick.AddListener(() => {
            AddGold(10);
            Debug.Log(10 + " of gold was added");
        });

        // Optional to remove linked listeners
        //button.onClick.RemoveAllListeners();
    }

    void AddGold(int amount)
    {
        gold += amount;
    }
}
