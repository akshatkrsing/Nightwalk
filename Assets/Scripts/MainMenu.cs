using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start() {
        AudioManager.instance.Play("Guide");
    }
    public void Play()
    {
        AudioManager.instance.Play("Start");
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game");
    }

<<<<<<< HEAD
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(Input.GetKeyDown(KeyCode.Escape))
=======
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
>>>>>>> cf62270560a4736bc60f1453cc545bd1e1c9a343
        {
            Application.Quit();
            Debug.Log("Player has quit the game");
        }
    }

}
