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
        string temporária = inputField.text;

        task1.text = temporária;
        StarSaveState ();
    }

    public void AddInputToTask2 () {
        string temporária = inputField.text;

        task2.text = temporária;
        StarSaveState ();
    }

    public void AddInputToTask3 () {
        string temporária = inputField.text;

        task3.text = temporária;
        StarSaveState ();
    }

    public void AddInputToTask4 () {
        string temporária = inputField.text;

        task4.text = temporária;
        StarSaveState ();
    }

    void Update () {

    }

    private void StarSaveState () {
        // Atualizar o arquivo que salva essas informações.
    }
}