using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardLevel : MonoBehaviour {
    private int num1, num2, myAns, n1, n2, countRound = 1;
    public static int score = 0;
    public Text txtbox1, txtbox2, myscore, noticeText, CountShow;
    public Button button1, button2, button3, NextButton;
    public Text buttonText1, buttonText2, buttonText3;

  

    // Use this for initialization
    void Start () {
        num1 = UnityEngine.Random.Range(14, 30);
        num2 = UnityEngine.Random.Range(5, 12);
        myAns = num1 - num2;
        n1 = UnityEngine.Random.Range((myAns+1), 30);
        n2 = UnityEngine.Random.Range(0, (myAns-1));

        MyRandomButton();
    }
	

    void MyRandomButton()
    {
        CountShow.text = countRound.ToString();
        num1 = UnityEngine.Random.Range(14, 30);
        num2 = UnityEngine.Random.Range(5, 12);
        myAns = num1 - num2;
        n1 = UnityEngine.Random.Range((myAns + 1), 30);
        n2 = UnityEngine.Random.Range(0, (myAns - 1));


        MyDefaults();

        myscore.text = score.ToString(); // display score

       int Rchoice = UnityEngine.Random.Range(1, 4);
        switch (Rchoice)
        {
            case 1:
                txtbox1.text = num1.ToString();
                txtbox2.text = num2.ToString();
                buttonText1.text = myAns.ToString();
                buttonText2.text = n1.ToString();
                buttonText3.text = n2.ToString();

                break;
            case 2:
                txtbox1.text = num1.ToString();
                txtbox2.text = num2.ToString();
                buttonText2.text = myAns.ToString();
                buttonText1.text = n1.ToString();
                buttonText3.text = n2.ToString();

                break;
            case 3:
                txtbox1.text = num1.ToString();
                txtbox2.text = num2.ToString();
                buttonText3.text = myAns.ToString();
                buttonText1.text = n1.ToString();
                buttonText2.text = n2.ToString();

                break;
            default:
                break;
        }


    }

    public void MyDefaults()
    {
        

        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
        button1.image.color = new Color(0.2F, 0.3F, 0.4F);
        button2.image.color = new Color(0.2F, 0.3F, 0.4F);
        button3.image.color = new Color(0.2F, 0.3F, 0.4F);
        noticeText.text = "";
        NextButton.gameObject.SetActive(false); // Next button turned off!
    }

    public void ChoiceButton1(Button btn1)
    {
        Debug.Log(btn1.name);
        if (buttonText1.text == myAns.ToString())
        {
            print("Button 1 is the right option!");
            score = score + 1;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button1.image.color = new Color(0.094F, 0.58F, 0.137F);

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Great! \nMove ahead!";
            noticeText.color = new Color(0.584F, 1F, 0.278F);



        }

        else
        {
            print("TRY AGAIN!!");
            button1.image.color = new Color(0.918F, 0.102F, 0.204F);
            button1.interactable = false;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Oh..NO! \nAnswer is: " + myAns;
            noticeText.color = new Color(0.918F, 0.047F, 0.047F);
            
        }
    }


    public void ChoiceButton2(Button btn2)
    {
        Debug.Log(btn2.name);
        if (buttonText2.text == myAns.ToString())
        {
            print("Button 2 is the right option!");
            score = score + 1;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button2.image.color = new Color(0.094F, 0.58F, 0.137F);

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Great! \nMove ahead!";
            noticeText.color = new Color(0.584F, 1F, 0.278F);
        }

        else
        {
            print("TRY AGAIN!!");
            button2.image.color = new Color(0.918F, 0.102F, 0.204F);
            button2.interactable = false;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Oh..NO! \nAnswer is: " + myAns;
            noticeText.color = new Color(0.918F, 0.047F, 0.047F);
        }
    }


    public void ChoiceButton3(Button btn3)
    {
        Debug.Log(btn3.name);
        if (buttonText3.text == myAns.ToString())
        {
            print("Button 3 is the right option!");
            score = score + 1;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button3.image.color = new Color(0.094F, 0.58F, 0.137F);

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Great! \nMove ahead!";
            noticeText.color = new Color(0.584F, 1F, 0.278F);
        }

        else
        {
            print("TRY AGAIN!!");
            button3.image.color = new Color(0.918F, 0.102F, 0.204F);
            button3.interactable = false;
            NextButton.gameObject.SetActive(true); // Next button turned ON!

            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            noticeText.text = "Oh..NO! \nAnswer is: " + myAns;
            noticeText.color = new Color(0.918F, 0.047F, 0.047F);
        }
    }



    public void NxtBtn(Button Xbtn)
    {
        countRound = countRound + 1;

        if (countRound <= 10)
        {
            Debug.Log(Xbtn.name);
            print("Moved to next QUestion!");
            MyRandomButton();
        }

        else {
            print("My score is: " + score);
            SceneManager.LoadScene("ScoreBoard");
           
        }
    }


    

}
