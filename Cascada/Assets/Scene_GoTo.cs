using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_GoTo : MonoBehaviour
{
    public int sceneNumber;

    public void GoToScene()
    {
        if (Application.CanStreamedLevelBeLoaded(sceneNumber))
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }

}
