using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class End_Level : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Subscribe to the sceneLoaded event
        //SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
               
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }

    //// This method will be called once the scene is loaded
    //private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    // Check if scene 3 is loaded
    //    if (scene.buildIndex == 3)
    //    {
    //        // Start the coroutine after scene 3 is loaded
    //        StartCoroutine(WaitingPlayCredits());
    //    }
    //}

    //IEnumerator WaitingPlayCredits()
    //{
    //    yield return new WaitForSeconds(10);
    //    SceneManager.LoadScene(4);
    //}

    //// Don't forget to unsubscribe to the event when the object is destroyed
    //void OnDestroy()
    //{
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}
}
