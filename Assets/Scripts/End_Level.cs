using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class End_Level : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
