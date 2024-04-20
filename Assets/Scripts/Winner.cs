using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Winner : MonoBehaviour
{
    public Text winnerName;
    public Button button;
    public void setName(string s){
        winnerName.text = s;
    }
    private void Awake(){
        button.onClick.AddListener(onClick);
    }
    public void onClick(){
        SceneManager.LoadScene("Gomoku");
    }
}
