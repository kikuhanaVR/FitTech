using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Signin_InfoManager : MonoBehaviour
{
    public TMP_InputField UsernameField;
    public TMP_InputField PasswordField;
    public string _username;
    public string _password;

    void Start()
    {
        
    }

    public void GetInput()
    {
        _username = UsernameField.text;
        _password = PasswordField.text;
        Debug.Log(_username + " " + _password);
    }

    public void MatchingInput() //DBとの照合
    {

    }

    public void Signin()
    {
        if (_username == "" || _password == "")
        {
            Debug.Log("未入力の項目があります");
        }
        else
        {
            Debug.Log("ログインしました");
            SceneManager.LoadScene("ChoiceMenu");
        }
    }
}
