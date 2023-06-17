using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene : MonoBehaviour
{
    public void SceneLoad(int number)
    {
        SceneManager.LoadScene(number);
    }
}
