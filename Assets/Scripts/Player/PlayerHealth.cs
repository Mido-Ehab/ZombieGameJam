using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 2;
    [SerializeField] GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        playerHealthCheck();
    }


    public void playerHealthCheck() 
    {
        if (health == 0)
        {
            gameOver.SetActive(true);
            Debug.Log("Player is dead");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            health -= 1;
            Debug.Log("Player Health: " + health);
        }
    }
}
