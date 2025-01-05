using UnityEngine;

public class EndSceneControll : MonoBehaviour
{
    [SerializeField] float delayBeforeVideo = 1f;
    [SerializeField] float delayBeforeQuit = 15f;

    [SerializeField] GameObject videoCredit;
    [SerializeField] GameObject winObject;

    private float timeElapsed;

    // Update is called once per frame
    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeVideo)
        {
            winObject.SetActive(false);
            videoCredit.SetActive(true);
        }

        if (timeElapsed > delayBeforeQuit)
        {
            Application.Quit();
        }
    }
}
