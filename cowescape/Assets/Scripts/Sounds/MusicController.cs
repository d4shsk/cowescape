using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private bool effects;

    void Start()
    {
        if (!effects)
        {
            if (MuteSounds.musicMuted)
            {
                gameObject.SetActive(false);
            }
        }
        else {
            if (MuteSounds.effectsMuted)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
