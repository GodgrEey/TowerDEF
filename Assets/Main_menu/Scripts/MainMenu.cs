using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string FirstLevel;
    public string SecondLevel;
    public string ThirdLevel;
    public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(FirstLevel);
    }
    public void ChooseLevel()
    {
        
    }
    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }
public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
}