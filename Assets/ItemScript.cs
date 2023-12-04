using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MainMenuManager;

public class ItemScript : MonoBehaviour
{
    public enum QuizState // your custom enumeration
    {
        Quiz,
        Benar,
        Salah
    };

    public int level;
    public int QuizIndex;

    public TMP_Text soal;
    public List<Button> optionButton;

    [SerializeField]
    private List<TMP_Text> quizText;
    private int answer;

    public TMP_Text timerText;

    public float timer;

    private float timerOr;

    private bool timerStarted;

    public GameObject quizContainer;
    public GameObject benarContainer;
    public GameObject salahContainer;

    private QuizState quizState;

    public void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("aa");
            SetQuiz();
        }
    }

    private void Update()
    {

        if (timerStarted)
        {
            if(timer > 0)
            {
                timer -= Time.deltaTime;
                UpdateTimerText();


            }

            if (timer <= 0) { 

                timer = 0f;
                UpdateTimerText();
                timerStarted = false;
            }

        }
        
    }

    private void SetQuiz()
    {
        QuizManager.instance.isOnQUiz = true;
        quizState = QuizState.Quiz;
        SetState();

        //soal.text = QuizManager.instance.quizDatabase.quizStruct[QuizIndex].Soal;
        soal.text = QuizManager.instance.quizDatabaseList[level].quizStruct[QuizIndex].Soal;

        for(int i = 0; i < 3; i++)
        {
            //TMP_Text tmp =  quizText[i];
            TMP_Text tmp = optionButton[i].transform.GetChild(0).GetComponent<TMP_Text>();
            tmp.text = QuizManager.instance.quizDatabaseList[level].quizStruct[QuizIndex].Jawaban[i];
            int answerIdx = i+1;
            optionButton[i].onClick.AddListener(delegate { AnswerClick(answerIdx); });
            timer = QuizManager.instance.quizDatabaseList[level].quizStruct[QuizIndex].time;
            timerOr = timer;
        }

        answer = QuizManager.instance.quizDatabaseList[level].quizStruct[QuizIndex].Benar;

        StartTimer();
    }

    public void AnswerClick(int index)
    {
        if(answer == index)
        {
            Benar();
            return;
        }
        if(answer != index)
        {
            Salah();
            return;
        }
    }

    private void Salah()
    {
        quizState = QuizState.Salah;
        SetState();

        Debug.Log("Salah");
    }
    private void Benar()
    {
        quizState = QuizState.Benar;
        SetState();

        Debug.Log("Benar");
    }

    private void StartTimer()
    {
        timerStarted = true;
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

        string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

        timerText.text = niceTime;
    }

    public void OnClickBaik(int i)
    {
        if(i == 0)
        {
            QuizManager.instance.isOnQUiz = false;
            Destroy(this.transform.parent.gameObject); 
            return;
        }

        if (i == 1)
        {
            SetQuiz();
        }
    }

    private void SetState()
    {
        quizContainer.SetActive(false);
        salahContainer.SetActive(false);
        benarContainer.SetActive(false);


        switch (quizState)
        {
            case QuizState.Quiz:
                quizContainer.SetActive(true);
                break;
            case QuizState.Benar:
                benarContainer.SetActive(true);
                break;
            case QuizState.Salah:
                salahContainer.SetActive(true);
                break;
        }
    }

}
