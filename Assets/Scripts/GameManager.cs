using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoretext;
    
    
    void Update()
    {
        scoretext.text = "Puntaje " + score;
        if (score >= 100)
        {
            SceneManager.LoadScene(1);
        }
    }
}
