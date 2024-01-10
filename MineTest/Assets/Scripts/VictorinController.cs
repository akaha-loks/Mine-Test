using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VictorinController : MonoBehaviour
{
    public int power = 1;

    public string textQuestion;
    public Text QuestionTextMain;

    public Button Answer;
    public Button Answer1;

    private int health;

    private void Start()
    {
        Question();
    }
    private void FixedUpdate()
    {
        health = PlayerPrefs.GetInt("health");
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
        health -= power;
        PlayerPrefs.SetInt("health", 0 + health);
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
