using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressColorizer : MonoBehaviour
{
    [SerializeField] private Image[] lvl1Buttons;
    public Color completedColor;

    void Start()
    {
        if (PlayerPrefs.HasKey("Level1Completed"))
        {
            lvl1Buttons[0].color = completedColor;
        }
        if (PlayerPrefs.HasKey("Level2Completed"))
        {
            lvl1Buttons[1].color = completedColor;
        }
        if (PlayerPrefs.HasKey("Level3Completed"))
        {
            lvl1Buttons[2].color = completedColor;
        }
    }

    void Update()
    {
        
    }
}
