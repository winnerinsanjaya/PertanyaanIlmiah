using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class QuizStruct
{
    [TextArea]
    public string Soal;
    public List<string> Jawaban;
    public int Benar;
}

[Serializable]
public class QuizDatabase
{
    public List<QuizStruct> quizStruct;
}
