using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aboutUS : MonoBehaviour {

    public void ReturnBack(Button CloseNow)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
