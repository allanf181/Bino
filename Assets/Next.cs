using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public int scene;
    public void LoadIndex(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
