using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomLevel : MonoBehaviour
{

    public int levelGenerate;
   

    public void LoadTheLevel()
    {
        levelGenerate = Random.Range(1, 7);
        SceneManager.LoadScene(levelGenerate);
    }

}
