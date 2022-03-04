using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLevel : MonoBehaviour
{
    public void SaveCurrentLevel() {
        string levelName = SceneManager.GetActiveScene().name;
        int levelCompleted = 1; // 1 - da; 0 - net
        PlayerPrefs.SetInt(levelName + "Completed", levelCompleted);
    }
}
