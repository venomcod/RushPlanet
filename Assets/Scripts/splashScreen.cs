using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreen : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Invoke("FirstLvlLoad", 2f);
    }

    // Update is called once per frame
    void FirstLvlLoad()
    {
        SceneManager.LoadScene(1);
    }
}
