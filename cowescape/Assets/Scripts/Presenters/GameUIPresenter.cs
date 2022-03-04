using UnityEngine;
using TMPro;

public class GameUIPresenter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statusText;
    [SerializeField] private TextMeshProUGUI timerText;


    public void UpdateTimerText(int timeLeft)
    {
        timerText.text = timeLeft.ToString();
    }

    public void SetPauseTexts() {
        timerText.enabled = false;
    }

    public void SetEndedPauseTexts(bool gameWon) {

        statusText.enabled = true;
        if (gameWon)
        {
            statusText.text = "U  won";
        }
        else
        {
            statusText.text = "U  loose";
        }
    }

    public void SetDefaultScreensState() {
        timerText.enabled = true;
    }
}
