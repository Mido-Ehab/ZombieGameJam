using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    
    private void OnTriggerStay(Collider other)
    {
      if (Input.GetKey(KeyCode.G))
        {
          
        }
    }
}
