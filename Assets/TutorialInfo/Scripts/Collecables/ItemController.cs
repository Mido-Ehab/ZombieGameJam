using UnityEngine;

public class TestInventory : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item testItem; // Drag a ScriptableObject here in the Inspector

    private void Start()
    {
        inventoryManager.Add(testItem);
        inventoryManager.ListItems();
    }
}