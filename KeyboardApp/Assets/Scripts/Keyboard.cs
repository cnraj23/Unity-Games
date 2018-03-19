using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public GameObject playhead;
    public GameObject myNote1;
    public float speed = 9000f;
    public AudioSource tones, singleKey;
    public AudioClip[] ToneArray;
    public Button[] Note1, Note2, Note3, Note4, Note5, Note6, Note7, Note8;

    [SerializeField] private Button[] Keys;
    List<int> KeyNumber = new List<int>();
    int i, forward, reversed;
    bool PressPlay = false;
    
    public Toggle echo_Tone, reverse_Tone, Qnone, Q1, Q2, Q3;

    Vector2 playheadposition;

    void Awake()
    {
        tones = GetComponent<AudioSource>();
        singleKey = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        echo_Tone.isOn = false;
        reverse_Tone.isOn = false;
        Qnone.isOn = true;
        Q1.isOn = false;
        Q2.isOn = false;
        Q3.isOn = false;
    }

    private AudioClip GetForwardClip(int myIndex)
    {
       
        print(KeyNumber[myIndex]);
        return ToneArray[KeyNumber[myIndex]];
    }

    void Update()
    {
        

        if (PressPlay)
        {
            
            playhead.transform.Translate(speed * 2 * Time.deltaTime * speed , 0, 0);
          
        }


        if (!tones.isPlaying && PressPlay == true && KeyNumber.Count != 0)
        {

           


            tones.clip = GetForwardClip(i);

            if (echo_Tone.isOn)  // Create Echo
            {
                tones.PlayDelayed(0.250f);
                tones.volume = 0.75f;
            }
            print(tones.clip.length);
          
            tones.PlayOneShot(tones.clip);
            print("My I is : " + i);
            

            if (reverse_Tone.isOn)
            {
                i--;
                if (i < 0)
                {
                    PressPlay = false;
                    print(PressPlay);
                }
            }
            else
            {
                i++;
                if (i == KeyNumber.Count)
                {
                    PressPlay = false;
                    print(PressPlay);
                }
            }

            
        }
        
        
    }

    public void MyKey1(Button key_1)
    {
        print(key_1.name);
        KeyNumber.Add(0);
        singleKey.clip = ToneArray[0];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }
  
        singleKey.PlayOneShot(singleKey.clip);

        // instantiate object
        if (KeyNumber.Count < 7)
        {
            Note1[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey2(Button key_2)
    {
        print(key_2.name);
        KeyNumber.Add(1);
        singleKey.clip = ToneArray[1];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }
        singleKey.time = 0.002f;
        
        singleKey.PlayOneShot(singleKey.clip);

        if (KeyNumber.Count < 7)
        {
            Note2[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey3(Button key_3)
    {
        print(key_3.name);
        KeyNumber.Add(2);
        singleKey.clip = ToneArray[2];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note3[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey4(Button key_4)
    {
        print(key_4.name);
        KeyNumber.Add(3);
        singleKey.clip = ToneArray[3];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note4[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey5(Button key_5)
    {
        print(key_5.name);
        KeyNumber.Add(4);
        singleKey.clip = ToneArray[4];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note5[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey6(Button key_6)
    {
        print(key_6.name);
        KeyNumber.Add(5);
        singleKey.clip = ToneArray[5];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note6[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey7(Button key_7)
    {
        print(key_7.name);
        KeyNumber.Add(6);
        singleKey.clip = ToneArray[6];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note7[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }
    public void MyKey8(Button key_8)
    {
        print(key_8.name);
        KeyNumber.Add(7);
        singleKey.clip = ToneArray[7];

        if (echo_Tone.isOn) // Create Echo
        {
            singleKey.PlayDelayed(0.250f);
            singleKey.volume = 0.75f;
        }

        singleKey.PlayOneShot(singleKey.clip);
        if (KeyNumber.Count < 7)
        {
            Note8[KeyNumber.Count - 1].gameObject.SetActive(true);
        }
        else
        {
            print("timeline is full!");
        }
        PressPlay = false;
    }


    public void PlayMe(Button PlayButton)
    {
       print(PlayButton.name);
        playhead.transform.position = new Vector3(95, 275, 0);
        PressPlay = true;
        
        reversed = KeyNumber.Count - 1;
        forward = 0;

        if (reverse_Tone.isOn)
        {
            i = reversed;
        }
        else
        {
            i = forward;
        }

    }

    public void EarseMe(Button EraseButton)
    {
        PressPlay = false;
        print(EraseButton.name);
        KeyNumber.Clear();

        SetAllKeysOff();
    }

    private void SetAllKeysOff()
    {
        for (int myCounter = 0; myCounter < 6; myCounter++)
        {
            Note1[myCounter].gameObject.SetActive(false);
            Note2[myCounter].gameObject.SetActive(false);
            Note3[myCounter].gameObject.SetActive(false);
            Note4[myCounter].gameObject.SetActive(false);
            Note5[myCounter].gameObject.SetActive(false);
            Note6[myCounter].gameObject.SetActive(false);
            Note7[myCounter].gameObject.SetActive(false);
            Note8[myCounter].gameObject.SetActive(false);
        }
    }

    public void StopMe(Button StopButton)
    {
        PressPlay = false;
        print(StopButton.name);
        playhead.transform.position = new Vector3(95, 275, 0);
        tones.Stop();
    }




}
