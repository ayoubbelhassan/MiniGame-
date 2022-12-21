
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnd = false;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        
    }
   public void GameOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Invoke("Restart", 2f);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
