using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Networking;

public class Register_InfoManager : MonoBehaviour
{
    public TMP_InputField UsernameField;
    public TMP_InputField PasswordField;
    public TMP_InputField ConfirmField;
    
    public string _username;
    public string _password;
    public string _confirm;

    class RegisterInfo
    {
        public string __username;
        public string __password;
        public string __confirm;
    }
    

    public void PostData() 
    {
        var url = "http://139.162.117.80/signup";

        var data = new RegisterInfo();
        data.__username = _username;
        data.__password = _password;
        data.__confirm = _confirm;

        var json = JsonUtility.ToJson(data);
        var postData = Encoding.UTF8.GetBytes(json);

        var request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST)
        {
            uploadHandler = new UploadHandlerRaw(postData),
            downloadHandler = new DownloadHandlerBuffer()
        };

        request.SetRequestHeader("Content-Type","application/json");

        var operation = request.SendWebRequest();

        operation.completed += _ =>
        {
            Debug.Log(operation.isDone);
            Debug.Log(operation.webRequest);
            Debug.Log(operation.webRequest.responseCode);
            Debug.Log(operation.webRequest.downloadHandler.text);
            Debug.Log("Http Error" + operation.webRequest.isHttpError);
            Debug.Log("Network Error" + operation.webRequest.isNetworkError);
        };
    }

    public void GetInput()
    {
        _username = UsernameField.text;
        _password = PasswordField.text;
        _confirm = ConfirmField.text;
        Debug.Log(_username + " " + _password + " " + _confirm);
    }

    public void Register()
    {
        if (_username == "" || _password == "" || _confirm == "")
        {
            Debug.Log("未入力の項目があります");
        }
        else
        {
            if (_password != _confirm)
            {
                Debug.Log("パスワードが一致しません");
            }
            if (_password == _confirm)
            {
                Debug.Log("パスワードが一致しました");
                SceneManager.LoadScene("ProfileMenu");
            }
        }
    }
}
