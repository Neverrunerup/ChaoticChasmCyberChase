using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcomplete : MonoBehaviour
{
   public void Loadnextlevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
