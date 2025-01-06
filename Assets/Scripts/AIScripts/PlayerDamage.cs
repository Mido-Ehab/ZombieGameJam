using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    private int Health = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerKillerZone"))
        {
            InvokeRepeating(nameof(DecreaseHealth),0,3f);
        }

        if (other.transform.tag == "Falling")
        {
            SceneManager.LoadScene(2);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerKillerZone"))
        {
            CancelInvoke(nameof(DecreaseHealth));
        }
    }

    private void DecreaseHealth()
    {
      
            Health--;

            Debug.Log("Player Health: " + Health);


            if (Health <= 0)
            {
                Debug.Log("Player has died!");
                SceneManager.LoadScene(2);
                Destroy(gameObject);
        }
       
    }
}
