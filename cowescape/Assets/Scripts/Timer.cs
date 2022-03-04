using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeUntilEnd;
    
    [SerializeField] private UnityEvent onGameFailed;

    [SerializeField] private UnityEvent onTimerStarted;
    [SerializeField] private UnityEvent<int> onTimeChanged;

    private float time;

    private bool gameFailed;

    private void Start()
    {
        gameFailed = false;
        onTimerStarted.Invoke();
    }

    private void Update()
    {
        time += Time.deltaTime;
        int timeLeft = (int)timeUntilEnd - (int)time;

        onTimeChanged.Invoke(timeLeft);

        if (timeLeft == 0 && !gameFailed) {
            onGameFailed.Invoke();
            gameFailed = true;
        }
    }
}
