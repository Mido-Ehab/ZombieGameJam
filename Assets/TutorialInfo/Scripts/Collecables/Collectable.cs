using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject PickupText;
    public AudioSource collectSource;
    public Item Item;

    void Start()
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None; 

        PickupText.SetActive(false);

    }

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickupText.SetActive(true);
            if (Input.GetKey(KeyCode.G))
            {
                collectSource.Play();
                this.gameObject.SetActive(false);
                PlayerPrefs.Save();
                Pickup();
                PickupText.SetActive(false);
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        PickupText.SetActive(false);
    }
}