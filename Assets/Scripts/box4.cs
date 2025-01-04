using UnityEngine;

public class box4 : MonoBehaviour
{
    public bool left;
    public bool up;
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

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z) && other.gameObject.name == "block2")
        {
            up = true;
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.z) && other.gameObject.name == "block3")
        {
            left = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Vector3 direction = other.transform.position - transform.position;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z) && other.gameObject.name == "block2")
        {
            up = false;
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.z) && other.gameObject.name == "block3")
        {
            left = false;
        }
    }
}
