using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreen : MonoBehaviour
{
    // Start is called before the first frame update
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
