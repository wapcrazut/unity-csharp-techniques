using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// This a simplified version of a Inventory system using a Dictionary
public class Inventory : MonoBehaviour
{
    Dictionary<string, int> items = new Dictionary<string, int>();

    [SerializeField] TMP_Text inventoryText;

    public void AddItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += 1;
        }
        else
        {
            items.Add(itemName, 1);
        }

        UpdateInventoryText();
    }

    public void RemoveItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] -= 1;

            if (items[itemName] == 0)
            {
                items.Remove(itemName);
            }
        }

        UpdateInventoryText();
    }

    void UpdateInventoryText()
    {
        inventoryText.text = string.Empty;

        foreach(KeyValuePair<string, int> item in items)
        {
            inventoryText.text += string.Format("{0} x{1}\n", item.Key, item.Value);
        }
    }
}
