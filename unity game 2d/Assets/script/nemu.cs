
using UnityEngine;
using UnityEngine.SceneManagement; //引用場景.api

public class nemu : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene("關卡1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
       
}