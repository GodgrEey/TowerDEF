using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelection : MonoBehaviour

{
    public string FirstLevel;
    public string SecondLevel;
    public string ThirdLevel;

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

            public void LoadScene()
    {
        SceneManager.LoadScene(SecondLevel);
        SceneManager.LoadScene(ThirdLevel);
    }

   
}
