using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
   public void Quit()
    {
        Debug.Log("ApplicationQuit");
        Application.Quit();
    }
   public void MenuOpen()
    {
        Debug.Log("OpenMenu");
        SceneManager.LoadScene(0);
    }
}
