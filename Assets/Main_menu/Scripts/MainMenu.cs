using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string FirstLevel;
    public string Level;
    public string SecondLevel;
    public string ThirdLevel;
    public GameObject optionsScreen;
     public GameObject LvlScreen;

     public GameObject CreditScreen;

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
        LvlScreen.SetActive(true);
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

        public void OpenCredit()
    {
        CreditScreen.SetActive(true);
    }

    public void CloseCredit()
    {
        CreditScreen.SetActive(false);
    }
}
