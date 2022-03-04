using UnityEngine;
using TMPro;

public class PauseUIPresenter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI effectsText;
    [SerializeField] private TextMeshProUGUI musicText;

    public void ChangeEffectsText(bool muted) {
        if (muted)
        {
            musicText.SetText("Unmute \n effects");
        }
        else
        {
            musicText.SetText("Mute \n effects");
        }
    }
    public void ChangeMusicText(bool muted) {
        if (muted)
        {
            effectsText.SetText("Unmute \n music");
        }
        else
        {
            effectsText.SetText("Mute \n music");
        }
    }
}
