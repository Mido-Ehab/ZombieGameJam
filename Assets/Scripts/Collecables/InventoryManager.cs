using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }
    public void Add(Item item)
    {
        Items.Add(item);
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }
    public void ListItems()
    {
        // Clear existing items in the UI
        foreach (Transform child in ItemContent)
        {
            Destroy(child.gameObject);
        }

        // Populate the inventory with current items
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);

            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            if (itemName != null && itemIcon != null)
            {
                itemName.text = item.itemName;
                itemIcon.sprite = item.icon;
            }
            else
            {
                Debug.LogWarning("ItemName or ItemIcon is missing from the prefab.");
            }
        }
    }

}