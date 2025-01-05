using UnityEditor.Compilation;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static Collectable Instance;
    public GameObject PickupText;
    public AudioSource collectSource;
    public Item firstKey;
    public bool hasFirstKey;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        hasFirstKey = false;

        PickupText.SetActive(false);

    }

    void Pickup()
    {
        InventoryManager.Instance.Add(firstKey);
        Destroy(gameObject);
        InventoryManager.Instance.ListItems();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickupText.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                collectSource.Play();
                hasFirstKey = true;
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