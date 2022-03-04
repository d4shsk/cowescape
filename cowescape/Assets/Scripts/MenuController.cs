using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(SceneLoader))] // Я понимаю, что это не норм, контроллировать сцены отсюда, но мне лень

public class MenuController : MonoBehaviour 
{
    [SerializeField] int nextSceneId;

    [SerializeField] GameObject pauseCanvas;

    [SerializeField] private UnityEvent onPauseStarted;

    private SceneLoader gameStart;

    private bool gameFailed;
    private bool holeEntered;

    void Start()
    {
        holeEntered = false;
        gameFailed = false;
        gameStart = GetComponent<SceneLoader>();
        pauseCanvas.SetActive(false);
    }


    public void StartPause() {
        onPauseStarted.Invoke();
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;

        print("PauseStarted");
    }

    public void SetContinueToRepeat() {
        gameFailed = true;
    }

    public void SetOnHoleEntered() {
        holeEntered = true;
    }

    public void StopPause()
    {
        Time.timeScale = 1;
        if (gameFailed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        else {
            if (holeEntered)
            {
                gameStart.LoadScene(nextSceneId);
            }
            else {
                pauseCanvas.SetActive(false);
            }
        }
    }

    public void GoToStartMenu() {
        SceneManager.LoadScene(0);
    }
}
