using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaderboardMenu : MonoBehaviour
{
    public void Back2Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Back2Leaderboard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }
}
