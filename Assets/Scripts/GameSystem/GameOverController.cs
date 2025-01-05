using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    //Play Again
    public void ResetScene()
    {
        SceneManager.LoadScene(1);
    }

    //Go back to menu
    public void MainMenu()
    {
        StartCoroutine(WaitingMenu());
    }
    IEnumerator WaitingMenu()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }

    // exit game
    public void QuitGame()
    {
        Application.Quit();
    }
}
