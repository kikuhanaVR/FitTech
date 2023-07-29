using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public TMP_InputField GoalField;
    public TMP_InputField ScoreField;
    string _goal;
    string _score;
    public GameObject Text01;
    public GameObject Text02;
    public GameObject Text03;
    public GameObject Text04;
    int _flag;
    public GameObject Chara2D;
    public Material Default2D_Material;
    public Material Good2D_Material;
    public Material Bad2D_Material;


    void Start()
    {
        Text01.SetActive(true);
        Text02.SetActive(false);
        Text03.SetActive(false);
        Text04.SetActive(false);
        GoalField.gameObject.SetActive(true);
        ScoreField.gameObject.SetActive(false);
        _flag = 0;
        Chara2D.GetComponent<Renderer>().material = Default2D_Material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoalInput()
    {
        _goal = GoalField.text;
        Debug.Log(_goal);
    }

    public void ScoreInput()
    {
        _score = ScoreField.text;
        Debug.Log(_score);
    }

    public void MainMenuManage() //Nextボタン用　メインメニューの管理
    {
        if(_flag == 0 && _goal != null)
        {
            Text01.SetActive(false);
            Text02.SetActive(true);
            Text03.SetActive(false);
            Text04.SetActive(false);
            GoalField.gameObject.SetActive(false);
            ScoreField.gameObject.SetActive(true);
            _flag = 1;
        }
        else if(_flag == 1 && int.Parse(_score) >= int.Parse(_goal))
        {
            Text01.SetActive(false);
            Text02.SetActive(false);
            Text03.SetActive(true);
            Text04.SetActive(false);
            GoalField.gameObject.SetActive(false);
            ScoreField.gameObject.SetActive(false);
            Chara2D.GetComponent<Renderer>().material = Good2D_Material;
            _flag = 2;
        }
        else if(_flag == 1 && int.Parse(_score) < int.Parse(_goal))
        {
            Text01.SetActive(false);
            Text02.SetActive(false);
            Text03.SetActive(false);
            Text04.SetActive(true);
            GoalField.gameObject.SetActive(false);
            ScoreField.gameObject.SetActive(false);
            Chara2D.GetComponent<Renderer>().material = Bad2D_Material;
            _flag = 2;
        }
        else if(_flag == 2)
        {
            SceneManager.LoadScene("ChoiceMenu");
        }
        
    }
    
    public void PostInput() //DBに送信,登録
    {

    }
}
