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

    class SigninInfo
    {
        public string email;
        public string password;
    }

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
        /*
        var url = "http://139.162.117.80/login";

        var data = new SigninInfo();
        data.email = _username;
        data.password = _password;

        var json = JsonUtility.ToJson(data);
        var postData = Encoding.UTF8.GetBytes(json);

        var request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET)
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
            Debug.Log(operation.webRequest.error);
            Debug.Log(operation.webRequest.responseCode);
            Debug.Log(operation.webRequest.downloadHandler.text);
            Debug.Log("Http Error" + operation.webRequest.isHttpError);
            Debug.Log("Network Error" + operation.webRequest.isNetworkError);
        };
        */
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
