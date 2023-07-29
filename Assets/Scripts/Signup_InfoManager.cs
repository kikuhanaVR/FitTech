using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Signup_InfoManager : MonoBehaviour
{
    public TMP_InputField UsernameField;
    public TMP_InputField PasswordField;
    public TMP_InputField ProfileField;
    public string _username;
    public string _password;
    public string _profile;

    public void GetInput()
    {
        _username = UsernameField.text;
        _password = PasswordField.text;
        _profile = ProfileField.text;
        Debug.Log(_username + " " + _password + " " + _profile);
    }

    public void PostInput() //DBに送信,登録
    {

    }
}
