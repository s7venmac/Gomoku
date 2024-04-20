using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public GameObject winner;
    private Board board;
    public Sprite xSprite;
    public Sprite oSprite;
    private Image image;
    private Button button;
    public int row;
    public int column;
    private Transform canvas;
    private void Awake(){
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }
    private void Start(){
        board = FindObjectOfType<Board>();
        canvas = FindObjectOfType<Canvas>().transform;
    }
    public void changeImage(string s){
        if(s == "x"){
            image.sprite = xSprite;
        }
        else {
            image.sprite = oSprite;
        }
    }
    public void onClick(){
        changeImage(board.currentTurn);
        if(board.Check(row,column)){
            GameObject game = Instantiate(winner, canvas);
            game.GetComponent<Winner>().setName("Winner is: " +board.currentTurn);
        }
        if(board.currentTurn == "x"){
            board.currentTurn = "o";
        }
        else{
            board.currentTurn = "x";
        }
    }
}
