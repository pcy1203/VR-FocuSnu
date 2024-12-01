using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTask1Scene()
    {
        SceneManager.LoadScene("Task1Scene_CardMatching");
    }

    public void LoadTask2Scene()
    {
        SceneManager.LoadScene("Task2Scene_RememberLocation");
    }

    public void LoadTask3Scene()
    {
        SceneManager.LoadScene("Task3Scene_PictureOrdering");
    }

    public void LoadTask4Scene()
    {
        SceneManager.LoadScene("Task4Scene_ObstacleAvoidance");
    }
    
    public void LoadTask5Scene()
    {
        SceneManager.LoadScene("Task5Scene_TableTennis");
    }
}
