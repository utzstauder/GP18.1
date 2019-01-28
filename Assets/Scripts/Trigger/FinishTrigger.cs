using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour, ITriggerable {

    public void Trigger()
    {
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        // get current scene
        Scene currentScene = SceneManager.GetActiveScene();

        // get scene index of current scene
        int targetSceneIndex = SceneUtility.GetBuildIndexByScenePath(currentScene.path);
        // targetSceneIndex = currentScene.buildIndex;

        // increment scene index
        targetSceneIndex++;

        // check if target scene in valid range
        if (targetSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogWarning("targetSceneIndex out of range. Loading first scene.");
            targetSceneIndex = 0;
        }

        // load target scene
        SceneManager.LoadScene(targetSceneIndex);
    }
}
