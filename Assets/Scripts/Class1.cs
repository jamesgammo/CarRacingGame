/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Class1 : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;
    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/register.php", form))
        {
            yield return www.SendWebRequest();
            // isNetworkError always comes true, else is to check for logs
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log("User creation failed. Error #" + www.text);
            }

            else (www..text == "0")
            {
                Debug.Log("User created succesfully!");
                UnityEngine.SceneManagement.SceneManager.LoadScene(MapSelect);
            }
        }
    }
    public void VerifyInput()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}
*/


