using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{

    public Transform Player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
