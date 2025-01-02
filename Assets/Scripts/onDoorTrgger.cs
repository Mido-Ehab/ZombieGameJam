using UnityEngine;

public class onDoorTrigger : MonoBehaviour
{
    public GameObject Door;            // Reference to the door GameObject
    public float rotationAngle = 90f; // Angle to rotate
    public float rotationSpeed = 2f;  // Speed of rotation

    private bool isPlayerInTrigger = false;  // Tracks if the player is in the trigger zone
    private bool isOpen = false;            // Tracks the door's state
    private Quaternion targetRotation;     // The target rotation of the door

    private void Start()
    {
        // Initialize the target rotation to the current rotation of the door
        targetRotation = Door.transform.rotation;
    }

    private void Update()
    {
        // Check if the player is in the trigger zone and presses the F key
       
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.F))
        {

            Debug.Log("F key pressed");
            // Toggle the door state
            isOpen = !isOpen;

            // Set the target rotation based on the door state
            if (isOpen)
            {
                targetRotation = Quaternion.Euler(Door.transform.eulerAngles + new Vector3(0, rotationAngle, 0));
            }
            else
            {
                targetRotation = Quaternion.Euler(Door.transform.eulerAngles - new Vector3(0, rotationAngle, 0));
            }
        }

        // Smoothly rotate the door toward the target rotation
        Door.transform.rotation = Quaternion.Lerp(Door.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger zone is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger zone");
            isPlayerInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object leaving the trigger zone is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger zone");
            isPlayerInTrigger = false;
        }
    }
}
