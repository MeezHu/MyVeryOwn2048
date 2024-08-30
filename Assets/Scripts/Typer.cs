using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text wordOutput = null;

    private string remainingWord = string.Empty;
    private string currentWord = "celingmasi";
    public bool canEnter;
    public GameObject mdpCanvas;

    public GameObject cLetter;
    public GameObject eLetter;
    public GameObject lLetter;
    public GameObject iLetter;
    public GameObject nLetter;
    public GameObject gLetter;
    public GameObject mLetter;
    public GameObject aLetter;
    public GameObject sLetter;
    public GameObject iLetter2;

    public bool isC;
    public bool isE;
    public bool isL;
    public bool isI;
    public bool isN;
    public bool isG;
    public bool isM;
    public bool isA;
    public bool isS;
    public bool isI2;


    private void Start()
    {
        SetCurrentWord();
        //PlayerPrefs.SetInt("knowspassword", 0);
    }

    private void SetCurrentWord()
    {
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    private void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("knowspassword"));

        CheckInput();

        if (canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            //SetCurrentWord();
            //PlayerPrefs.SetInt("knowspassword", 1);
            mdpCanvas.SetActive(false);
            
        }

        if (isC)
        {
            cLetter.SetActive(true);
        }
        if (isE)
        {
            eLetter.SetActive(true);
        }
        if (isL)
        {
            lLetter.SetActive(true);
        }
        if (isI)
        {
            iLetter.SetActive(true);
        }
        if (isN)
        {
            nLetter.SetActive(true);
        }
        if (isG)
        {
            gLetter.SetActive(true);
        }
        if (isM)
        {
            mLetter.SetActive(true);
        }
        if (isA)
        {
            aLetter.SetActive(true);
        }
        if (isS)
        {
            sLetter.SetActive(true);
        }
        if (isI2)
        {
            iLetter2.SetActive(true);
        }

    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if(keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(isCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if (isWordComplete())
                CanEnter();
        }
    }

    private bool isCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        if (isC == false)
        {
            isC = true;
            
        }
        else if (isC == true && isE == false)
        {
            isE = true;
            
        }
        else if (isC == true && isE == true && isL == false)
        {
            isL = true;
        }
        else if (isC == true && isE == true && isL == true && isI == false)
        {
            isI = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == false)
        {
            isN = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == true && isG == false)
        {
            isG = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == true && isG == true && isM == false)
        {
            isM = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == true && isG == true && isM == true && isA == false)
        {
            isA = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == true && isG == true && isM == true && isA == true && isS == false)
        {
            isS = true;
        }
        else if (isC == true && isE == true && isL == true && isI == true && isN == true && isG == true && isM == true && isA == true && isS == true && isI2 == false)
        {
            isI2 = true;
        }

        SetRemainingWord(newString);
    }

    private bool isWordComplete()
    {
        return remainingWord.Length == 0;
    }

    private void CanEnter()
    {
        canEnter = true;
    }
}
