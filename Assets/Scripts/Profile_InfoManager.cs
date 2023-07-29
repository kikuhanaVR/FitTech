using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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

    public void GetInput()
    {
        _name = NameField.text;
        _age = AgeField.text;
        _gender = GenderField.text;
        _hobby = HobbyField.text;
        _description = DescriptionField.text;
        Debug.Log(_name + " " + _age + " " + _gender + " " + _hobby + " " + _description);
    }

    public void PostInput() //DBに送信,登録
    {

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
