using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movingtomenus : MonoBehaviour
{
    // EZ time trial 
    public void EZTimeTrial()
    {
        SceneManager.LoadScene("EZ - TimeTrial");
    }

    // DT Tutorial 
    public void DTTutorial()
    {
        SceneManager.LoadScene("DT - Tutorial");
    }

    // DT TimeTrial
    public void DTTimeTrial()
    {
        SceneManager.LoadScene("DT");
    }

    // Hard Level Tutorial
    public void HLTutorial()
    {
        SceneManager.LoadScene("HL - Tutorial");
    }

    //Hard level TimeTrial 
    public void HLTimeTrial()
    {
        SceneManager.LoadScene("HL - TT");
    }
}
