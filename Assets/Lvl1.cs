using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl1 : MonoBehaviour
{
     public string FirstLevel;

     public string BackMain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void Level1()
    {
        SceneManager.LoadScene(FirstLevel);
    }

        public void backMenu()
    {
        SceneManager.LoadScene(BackMain);
    }
}
