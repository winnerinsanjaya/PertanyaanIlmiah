using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public QuizDatabase quizDatabase;

    public static QuizManager instance;

    public bool isOnQUiz;

    public void Awake()
    {
        instance = this;
    }
}
