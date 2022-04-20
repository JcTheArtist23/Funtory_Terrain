using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public bool canPlay;

    private void Start()
    {
        canPlay = true;
    }

    private void Update()
    {
        if(canPlay == true)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            canPlay = false;
            SceneManager.LoadScene(sceneName);
        }
    }
}
