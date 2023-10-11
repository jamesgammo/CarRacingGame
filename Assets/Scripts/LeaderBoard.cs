using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    // creates variables to upload into unity 
    string a = string.Empty;
    string b = string.Empty;

    public Text Score;
    public Text Username;

    // creation of an array of usernames from the leaderboard 
    string[] array2  = new string[1000];

    // array creation of for the scores inside of the leaderboard as initgers 
    int[] array1 = new int[1000];


    List<int> list = new List<int>();
    string temp;


    // immediately after opening the leaderboar script the resutls are imported and updated
    void Awake()
    {
        StartCoroutine(BubbleSort());
    }


    IEnumerator BubbleSort()
    {
        // creates a form that will retrieve the current scores and inputs from the leaderboard and input them 
        // into the array 

        WWW www = new WWW("http://localhost/sqlconnect/leaderboard.php");

        yield return www;

        // splits the usernames from a single line of string into differnet lines 
        string[] result = www.text.Split('\t');
        
        //takes the first element in th results and while is less than total results
        // then adds 2 to get to the next username 

        // score array 
        for (int i = 1; i < result.Length; i += 2)
        {
            // changes the position of score to an intiger 
            // passing the value of the leaderboard by value
            int Num = int.Parse(result[i]);

            // array elements are now value numbers 
            array1[i] = Num;
        }
        
        int temp = 0;

        // for every element in the array
        for (int write = 0; write < array1.Length; write++)
        {
            // Last i elements are already in place 
            for (int sort = 0; sort < array1.Length - 1; sort++)
            {
                // checks the position of the score, if it is smaller than than the one above 

                // if (array1[sort] < array1[sort + 1])
                if (array1[sort] > array1[sort + 1])
                {

                // temp is the current element
                    temp = array1[sort + 1];
                    // moves onto the next element 
                    array1[sort + 1] = array1[sort];
                    // makes the current element to the adjacenet one 
                    array1[sort] = temp;
                }
            }
        }
        //code to implement into the unity leaderboard

        // for each element in the score array 
        for (int j = 0; j < array1.Length; j++)
        {
            // if the element is larger than the first one 
            if (array1[j] > 1)
            {
                // a = string variable inputting the score into 
                // a now becomes the current score in the array1[j] the current second best 
                a = a + (array1[j].ToString() + "\n");

                // creating a form to submit to the database 
                WWWForm form = new WWWForm();
                // incramenting the score variable to have the sorted score 

                // posts the score and variable to the form 
                form.AddField("score", array1[j]);

                // php script which assigns the score variable to the username stored in the database 
                WWW www2 = new WWW("http://localhost/sqlconnect/RetrieveUsername.php", form);

                // returns of the usernames from the php script from the database 
                yield return www2;

                // array which stores the string of usernames with associated scores 
                string[] result2 = www2.text.Split('\t');
                // partitioins the values returned from the query 

                for (int q = 0; q < result2.Length; q++)
                {
                    // b (the usernames) are converted to string and assinged to the b array 
                    b = b + (result2[q].ToString() + "\n");
                }
            }
        }
        
        // assings these to game objects inside of unity 
        Score.text = (a);
        Username.text = (b); 



    }


}
