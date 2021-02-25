using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasEnded = false;
   public void EndGame()
    {
        if (hasEnded)
            return;
        hasEnded = true;
        StartCoroutine(PlayEndGameAnimation());
        Debug.Log("Game Over!");
    }
    
    IEnumerator PlayEndGameAnimation()
    {
        Debug.Log("Game Over");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
