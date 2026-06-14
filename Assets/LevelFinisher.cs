using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher : SceneOpener
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        DontDestroyOnLoad(other.gameObject);


        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;


        int nextSceneIndex = currentSceneIndex + 1;


        OpenScene(nextSceneIndex);



    }
}

