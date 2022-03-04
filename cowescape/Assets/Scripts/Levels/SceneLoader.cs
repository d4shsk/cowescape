using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Animator transition;

    [SerializeField] private float transitionTime = 1f;

    public void LoadScene(int sceneId) {
        SceneManager.LoadScene(sceneId);
        Time.timeScale = 1;
    }

    private IEnumerator LoadLevel(int sceneId) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);

        
    }
}
