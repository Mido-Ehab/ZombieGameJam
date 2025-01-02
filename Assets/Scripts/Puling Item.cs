using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PullingItem : MonoBehaviour
{
    [SerializeField] private float ForceMagnitude = 30f;
    [SerializeField] private float range = 5f;

    private bool isDragging = false;
    
    private void Update() 
    {
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 1000f)) 
        {
            float distance = Vector3.Distance(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), hitInfo.point);
            Rigidbody rigidbody = hitInfo.collider.GetComponent<Rigidbody>();

            if (hitInfo.collider.CompareTag("Pullable") && Input.GetKey(KeyCode.M) && distance < range)
            {
                rigidbody.transform.SetParent(this.transform, true);
                //rigidbody.transform.SetParent(this.transform, false);
                rigidbody.transform.position = Vector3.zero; 
            }
            else 
            {
                rigidbody.transform.SetParent(null);
            }
        }   
    }
}