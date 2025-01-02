using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Speed of movement
    [SerializeField] private float gravity = -9.81f; // Gravity force
    [SerializeField] private float jumpHeight = 2f; // Jump height
    [SerializeField] private GameObject targetObject; // Reference to another GameObject

    private CharacterController characterController;
    private Vector3 velocity; // Tracks vertical velocity for gravity

    private void Start()
    {
        // Get the CharacterController component
        characterController = GetComponent<CharacterController>();
        if (characterController == null)
        {
            Debug.LogError("No CharacterController component found on the GameObject.");
        }
    }

    private void Update()
    {
        MoveCharacter();

        if (Input.GetKeyUp(KeyCode.M))
        {
            DisableTargetComponent();
        }
    }

    private void MoveCharacter()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.right * horizontal + transform.forward * vertical;

        if (characterController != null)
        {
            characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        }

        if (characterController.isGrounded)
        {
            velocity.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }
        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }

    private void DisableTargetComponent()
    {
        if (targetObject != null)
        {
            // Access and disable the component (e.g., CharacterController)
            CharacterController targetController = targetObject.GetComponent<CharacterController>();
            if (targetController != null)
            {
                targetController.enabled = false; // Disable the component
                Debug.Log("CharacterController on target object has been disabled.");
            }
            else
            {
                Debug.LogError("No CharacterController found on the target object.");
            }
        }
        else
        {
            Debug.LogError("Target object is not assigned.");
        }
    }
}
