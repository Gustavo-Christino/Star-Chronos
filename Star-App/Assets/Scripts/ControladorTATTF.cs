using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorTATTF : MonoBehaviour {

    public TextMeshProUGUI inputField;
    public TextMeshProUGUI task1, task2, task3, task4;

    void Start () {

    }

    public void AddInputToTask1 () {
        string tempor�ria = inputField.text;

        task1.text = tempor�ria;
        StarSaveState ();
    }

    public void AddInputToTask2 () {
        string tempor�ria = inputField.text;

        task2.text = tempor�ria;
        StarSaveState ();
    }

    public void AddInputToTask3 () {
        string tempor�ria = inputField.text;

        task3.text = tempor�ria;
        StarSaveState ();
    }

    public void AddInputToTask4 () {
        string tempor�ria = inputField.text;

        task4.text = tempor�ria;
        StarSaveState ();
    }

    void Update () {

    }

    private void StarSaveState () {
        // Atualizar o arquivo que salva essas informa��es.
    }
}