using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuControl : MonoBehaviour
{
    [SerializeField] List<GameObject> panelList = new List<GameObject>();

    public void OnButtonClick(GameObject on)
    {

        foreach (GameObject panelOff in panelList)
        {
            panelOff.SetActive(false);
        }

        on.SetActive(true);
    }

    public void PlayGame()
    {
        StartCoroutine(WaitingPlayGame());
    }

    IEnumerator WaitingPlayGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
