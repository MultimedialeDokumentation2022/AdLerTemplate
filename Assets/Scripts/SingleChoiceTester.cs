using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SingleChoiceTester : MonoBehaviour
{
    public Text frage;
    public Text antwort1;
    public Text antwort2;
    public Text antwort3;
    public Text antwort4;
    public int richtigeAntwort;

    public ColorBlock rightAnswer;

    public SingleChoiceElement[] frageliste;

    void Start() {
        loadQuestion(0);
    }
    void Update() {
        
    }

    void loadQuestion(int questionNumber){
        frage.text = frageliste[questionNumber].frage;
        antwort1.text = frageliste[questionNumber].antwort1;
        antwort2.text = frageliste[questionNumber].antwort2;
        antwort3.text = frageliste[questionNumber].antwort3;
        antwort4.text = frageliste[questionNumber].antwort4;
        richtigeAntwort = frageliste[questionNumber].richtigeAntwort;
    }
}
