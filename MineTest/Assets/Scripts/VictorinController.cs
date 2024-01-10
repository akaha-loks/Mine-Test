using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VictorinController : MonoBehaviour
{
    public string textQuestion;
    public Text QuestionTextMain;

    public Button Answer;
    public Button Answer1;

    private int health;

    private void Start()
    {
        health = PlayerPrefs.GetInt("health");
        Question();
    }
    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("health") == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void Question()
    {
        QuestionTextMain.text = textQuestion;
    }
    public void AnswerTrue()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    public void AnswerFalse()
    {
        health -= 1;
        PlayerPrefs.SetInt("health", health);
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
