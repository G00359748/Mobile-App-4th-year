using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }




    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}

