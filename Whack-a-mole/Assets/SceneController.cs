using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject fadeCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if (!FadeManager.isFadeInstance)
        {
            Instantiate(fadeCanvas);
        }
    }

    void findFadeObject()
    {
        fadeCanvas = GameObject.FindGameObjectWithTag("Fade");
        fadeCanvas.GetComponent<FadeManager>().fadeIn();
    }

    public async void sceneChange(string InGameScene)
    {
        fadeCanvas.GetComponent<FadeManager>().fadeOut();
        await Task.Delay(200);
        SceneManager.LoadScene("InGameScene");
    }
}
