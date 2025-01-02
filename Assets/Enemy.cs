using UnityEngine;

public class Enemy : MonoBehaviour
{
    PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            playerHealth.health -= 1;
            Debug.Log("Player Health" + playerHealth.health);
        }
    }
}
