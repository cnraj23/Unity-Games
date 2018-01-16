using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour {

    private int ReceivedScore ;
    public Text scoreShowText, AnotherText;
    public Button homeButton;

	// Use this for initialization
	void Start () {

        ReceivedScore = 0;
        if (MainMenu.levelCounter == 1)
        {
            ReceivedScore = MyQuiz.score;
            print("Easy Level score is: " + ReceivedScore);
            MyQuiz.score = 0;
            MediumLevel.score = 0;
            HardLevel.score = 0;
        }
        if (MainMenu.levelCounter == 2)
        {
            ReceivedScore = MediumLevel.score;
            print("Medium Level score is: " + ReceivedScore);
            MyQuiz.score = 0;
            MediumLevel.score = 0;
            HardLevel.score = 0;
        }
        if (MainMenu.levelCounter == 3)
        {
            ReceivedScore = HardLevel.score;
            print("Hard Level score is: " + ReceivedScore);
            MyQuiz.score = 0;
            MediumLevel.score = 0;
            HardLevel.score = 0;
        } 



        print(ReceivedScore);

        if (ReceivedScore >= 8)
        {
            scoreShowText.text = ReceivedScore.ToString();
            scoreShowText.color = new Color(0.42F, 0.839F, 0.475F);
            AnotherText.color = new Color(0.42F, 0.839F, 0.475F);
        }

        if (ReceivedScore >=5 && ReceivedScore < 8 )
        {
            scoreShowText.text = ReceivedScore.ToString();
            scoreShowText.color = new Color(0.839F, 0.549F, 0.035F);
            AnotherText.color = new Color(0.839F, 0.549F, 0.035F);
        }

        if (ReceivedScore >= 0 && ReceivedScore < 5)
        {
            scoreShowText.text = ReceivedScore.ToString();
            scoreShowText.color = new Color(1F, 0.102F, 0.184F);
            AnotherText.color = new Color(1F, 0.102F, 0.184F);
        }



    }

    public void ReturnBack(Button homeNow)
    {
       SceneManager.LoadScene("MainMenu");
    }

}
