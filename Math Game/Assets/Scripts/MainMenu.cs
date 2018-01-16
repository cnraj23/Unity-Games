using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static int levelCounter = 0;

    public void EasyLevel(Button easyBtn)
    {
        Debug.Log(easyBtn.name);

        SceneManager.LoadScene("Easy_Level");
        levelCounter = 1;
    }

    public void MediumLevel(Button mediumBtn)
    {
        Debug.Log(mediumBtn.name);

        SceneManager.LoadScene("Medium_Level");
        levelCounter = 2;
    }

    public void HardLevel(Button hardBtn)
    {
        Debug.Log(hardBtn.name);

        SceneManager.LoadScene("Hard_Level");
        levelCounter = 3;
    }

    public void AboutUS(Button abtus)
    {
        Debug.Log(abtus.name);

        SceneManager.LoadScene("AboutUs");    
    }


}
