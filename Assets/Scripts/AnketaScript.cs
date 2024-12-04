using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AnketaScript : MonoBehaviour {         
    public TMP_InputField nameInputField;
    public TMP_Text nameTmpText;
    public TMP_InputField ageInputField;
    public TMP_Text ageTmpText;
    private void Start() {
        nameInputField.onEndEdit.AddListener(NameInputFieldOneEndEdit);
        ageInputField.onEndEdit.AddListener(AgeInputFieldOneEndEdit);
    }
    private void NameInputFieldOneEndEdit(string text) {
        Debug.Log("AnketaScript: :NameInputFieldOneEndEdit() -- text:" + text);      
        OnButtonUserName();
    }
    private void AgeInputFieldOneEndEdit(string text) {
        Debug.Log("AnketaScript: :AgeInputFieldOneEndEdit() -- text:" + text);
        OnButtonUserAge();
    }
    public void OnButtonUserName() {
        Debug.Log("AnketaScript: :OnButtonUserName() -- nameInputField.text:" + nameInputField.text);
        nameTmpText.text = nameInputField.text;

    }
    public void OnButtonUserAge() {
        Debug.Log("AnketaScript: :OnButtonUserAge() -- ageInputField.text:" + ageInputField.text);
        string ageString = ageInputField.text;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) {
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddYears(-ageInt);
                ageTmpText.text = dateTime.ToString("yyyy");
            } else {
                ageTmpText.text = "Нужно только число!";
            }
        } else {
             ageTmpText.text = "Не должно быть пустой!";
        }
    }
}                
        





   

