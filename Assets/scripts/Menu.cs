using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void Quit()
    {
        Debug.Log("ApplicationQuit");
        Application.Quit();
    }
    public void StartGame()
    {

        Debug.Log("StartGame");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
