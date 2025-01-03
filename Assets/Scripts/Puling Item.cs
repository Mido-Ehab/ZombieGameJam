using Unity.VisualScripting;
using UnityEngine;

public class PullingItem : MonoBehaviour
{
    [SerializeField] private float ForceMagnitude = 30f;
    [SerializeField] private float range = 0f;

    // Logic
    private bool isDragging = false;

    // Ray Casting
    private RaycastHit hitInfo;

    private void Update() 
    {
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y , transform.position.z), transform.TransformDirection(Vector3.forward), out hitInfo, 1000f)) 
        {
            float distance = Vector3.Distance(new Vector3(transform.position.x, transform.position.y , transform.position.z), hitInfo.point);
            

            if (hitInfo.collider.CompareTag("Pullable") && Input.GetKey(KeyCode.M) && distance < range)
            {
                isDragging = true;
            }
            else 
            {
                isDragging = false;
            }

            
        }   
        
        Rigidbody rigidbody = hitInfo.collider.GetComponent<Rigidbody>();

        if (isDragging)
            {
                Vector3 boxDirection = hitInfo.transform.position;
                boxDirection.y = hitInfo.transform.position.y;
                
                Vector3 forceDirection = this.transform.position - hitInfo.transform.position;

                forceDirection.y = 0;
                forceDirection.Normalize();

                rigidbody.AddForce(forceDirection * ForceMagnitude, ForceMode.Impulse);
            }
    }
}
