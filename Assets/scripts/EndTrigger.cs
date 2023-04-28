using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    void OnTriggerEnter (Collider colliderInfo)
    {
        if (colliderInfo.GetComponent<Collider>().tag == "Player")
        {
            FindObjectOfType<GameManager>().CompletedLevel();

        }
    }
}
