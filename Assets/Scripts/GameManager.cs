using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 600f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;
    public Rigidbody rb;
    

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            movement.StopPlayer();
            Invoke("Restart", restartDelay/6);
        } 
    }

    public void CompleteLevel()
    {     
        //completeLevelUI.SetActive(true);  //commented out until I can get it to display properly.
        movement.StopPlayer();
        Invoke("NextScene", 6f);
        //NextScene();
    }
    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
