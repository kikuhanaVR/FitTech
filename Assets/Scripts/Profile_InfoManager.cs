using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Networking;

public class Profile_InfoManager : MonoBehaviour
{
    public TMP_InputField NameField;
    public TMP_InputField AgeField;
    public TMP_InputField GenderField;
    public TMP_InputField HobbyField;
    public TMP_InputField DescriptionField;
    public string _name;
    public string _age;
    public string _gender;
    public string _hobby;
    public string _description;

    class ProfileInfo
    {
        public string name;
        public string age;
        public string gender;
        public string hobby;
        public string desc;
    }

    public void PostData() 
    {
        var url = "http://139.162.117.80/signup";

        var data = new ProfileInfo();
        data.name = _name;
        data.age = _age;
        data.gender = _gender;
        data.hobby = _hobby;
        data.desc = _description;

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
            Debug.Log(operation.webRequest.error);
            Debug.Log(operation.webRequest.responseCode);
            Debug.Log(operation.webRequest.downloadHandler.text);
            Debug.Log("Http Error" + operation.webRequest.isHttpError);
            Debug.Log("Network Error" + operation.webRequest.isNetworkError);
        };
    }

    public void GetInput()
    {
        _name = NameField.text;
        _age = AgeField.text;
        _gender = GenderField.text;
        _hobby = HobbyField.text;
        _description = DescriptionField.text;
        Debug.Log(_name + " " + _age + " " + _gender + " " + _hobby + " " + _description);
    }
    public void Register()
    {
        if(_name == "" || _age == "" || _gender == "" || _hobby == "" || _description == "")
        {
            Debug.Log("未入力の項目があります");
        }
        else
        {
            Debug.Log("登録しました");
            SceneManager.LoadScene("ChoiceMenu");
        }
    }
}
