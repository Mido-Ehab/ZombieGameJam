using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCreditsVideo : MonoBehaviour
{
    private void Update()
    {
        
    }

    public void PlayCredits()
    {
        StartCoroutine(WaitingPlayCredits());
    }

    IEnumerator WaitingPlayCredits()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
