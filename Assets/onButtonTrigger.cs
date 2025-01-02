using System.Collections;
using UnityEngine;

public class onButtonTrigger : MonoBehaviour
{
    public GameObject box;
    bool isPlayerInTriggerArea = false;
    bool isTriggered = false;

    private Renderer boxRenderer;
    private Color originalColor;
    [SerializeField] private Color newColor = Color.red;

    void Start()
    {
        if (box != null)
        {
            boxRenderer = box.GetComponent<Renderer>();
            if (boxRenderer != null)
            {
                originalColor = boxRenderer.material.color;
            }
            else
            {
                Debug.LogWarning("Box does not have a Renderer component.");
            }
        }
        else
        {
            Debug.LogError("Box GameObject is not assigned in the Inspector.");
        }
    }

    void Update()
    {
        if (isPlayerInTriggerArea && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("HELLO FROM TRIGGER BOX");
            isTriggered = !isTriggered;

            if (boxRenderer != null)
            {
                boxRenderer.material.color = isTriggered ? newColor : originalColor;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("HELLO FROM BUTTON");
            isPlayerInTriggerArea = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("LEFT BUTTON TRIGGER");
            isPlayerInTriggerArea = false;
        }
    }
}
