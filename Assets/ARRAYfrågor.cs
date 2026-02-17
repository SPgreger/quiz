using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ARRAYfrågor : MonoBehaviour
{
    [SerializeField] Question[] frågor;
    int currentQuestion = 0;

    int heart = 3;
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite fullHeart, emptyHeart;

    [SerializeField] TMP_Text questionText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    void NextQuestion()
    {
        currentQuestion++;
    }

    public void AnswerYes()
    {
        if (frågor[currentQuestion].answers[1].isCorrect)
        {
            print("rätt");
            NextQuestion();
        }
        else
        {
            print("fel");
            heart--;
            NextQuestion();
        }
    }
    public void AnswerNo() {

        if (frågor[currentQuestion].answers[0].isCorrect)
        {
            print("rätt");
            NextQuestion();
        }
        else
        {
            print("fel");
            heart--;
            NextQuestion();
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (currentQuestion >= frågor.Length)
        {
            SceneManager.LoadScene(4); 
        } 

        if(heart <= 0)
        {
            SceneManager.LoadScene(3);
        }
        

        questionText.text =  $"Fråga {currentQuestion+1}: " + frågor[currentQuestion].question;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i > heart - 1)
            {
                hearts[i].sprite = emptyHeart;
            }

        }
    }
}

[Serializable]
class Question
{
    public string question;
    public Answer[] answers;

}
[Serializable]
class Answer
{
    public string answer;
    public bool isCorrect;

   // string[Question]{print question}
}