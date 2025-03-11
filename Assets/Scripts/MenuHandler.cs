using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuHandler : MonoBehaviour
{
    private string nameText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewGame()
    {
        if (nameText != null)
        {
            DataManager.Instance.playerName = nameText;
            SceneManager.LoadScene(1);
        }
        
    }

    public void ExitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code
#endif

    }

    public void InputGrabber(string input)
    {
        nameText = input;
        Debug.Log(input);
        
    }
    
}
