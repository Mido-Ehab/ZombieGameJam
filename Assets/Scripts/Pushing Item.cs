using UnityEngine;

public class PushingItem: MonoBehaviour
{
    [SerializeField] private float ForceMagnitude;
    void start() 
    {

    }

    void update()
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        Rigidbody rigidBody = hit.collider.attachedRigidbody;

        if (rigidBody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - this.transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            // 1. Vector3 direction adn magnitude
            // 2. Vector3 Position The world-space position where the force is applied
            // 3. ForceMode.Impulse apply force considering the object's mass (heavier objects need more force)
            rigidBody.AddForceAtPosition(forceDirection * ForceMagnitude, this.transform.position, ForceMode.Impulse);
        }
    }


}
