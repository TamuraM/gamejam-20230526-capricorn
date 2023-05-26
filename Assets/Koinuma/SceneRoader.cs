using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRoader : MonoBehaviour
{
    public void SceneRoad (string sceneName)
    {
        SceneManager.LoadScene (sceneName);
    }
}
