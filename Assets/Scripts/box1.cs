using Unity.VisualScripting;
using UnityEngine;

public class box1 : MonoBehaviour
{
    public bool right;
    public bool down;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 direction = other.transform.position - transform.position;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z)&& other.gameObject.name=="block3")
        {
            down = true;
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.z)&& other.gameObject.name=="block2")
        {
            right = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Vector3 direction = other.transform.position - transform.position;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z) && other.gameObject.name == "block3")
        {
            down = false;
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.z) && other.gameObject.name == "block2")
        {
            right = false;
        }
    }
}
