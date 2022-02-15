using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeValue = 10;
    public Text TimerText;
    public Text TimerExpireText;
    public Text GameplayInstructionText;
    public Text SelectionTextWRONG;
    public Text SelectionTextWRONG2;
    public Text SelectionTextRIGHT;
    public Text WrongChoiceText;
    public Text RightChoiceText;

    
    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            TimerExpireText.gameObject.SetActive(true);
            GameplayInstructionText.gameObject.SetActive(false);
            SelectionTextWRONG.gameObject.SetActive(false);
            SelectionTextRIGHT.gameObject.SetActive(false);
            SelectionTextWRONG2.gameObject.SetActive(false);
            WrongChoiceText.gameObject.SetActive(false);
            RightChoiceText.gameObject.SetActive(false);
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
