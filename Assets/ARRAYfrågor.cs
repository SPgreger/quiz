using System;
using TMPro;
using UnityEngine;

public class ARRAYfrågor : MonoBehaviour
{
    [SerializeField] Question[] frågor;
    int currentQuestion = 0;

    [SerializeField] TMP_Text questionText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        questionText.text =  $"Fråga {currentQuestion+1}: " + frågor[currentQuestion].question;
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