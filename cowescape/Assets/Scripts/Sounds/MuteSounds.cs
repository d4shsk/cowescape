using UnityEngine;
using UnityEngine.Events;

public class MuteSounds : MonoBehaviour
{
    [SerializeField] private UnityEvent<bool> onMusicToggle;
    [SerializeField] private UnityEvent<bool> onEffectsToggle;

    public static bool musicMuted = false;
    public static bool effectsMuted = false;

    private void Start()
    {
        onMusicToggle.Invoke(musicMuted);
        onEffectsToggle.Invoke(effectsMuted);
    }

    public void ToggleMusic() {
        musicMuted = !musicMuted;
        onMusicToggle.Invoke(musicMuted);
    }

    public void ToggleEffects()
    {
        effectsMuted = !effectsMuted;
        onEffectsToggle.Invoke(effectsMuted);
    }
}
