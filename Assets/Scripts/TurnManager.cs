using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TurnManager : MonoBehaviour
{
    public GameData gameData;
    public Player turnPlayer;
    private int playerToCall;
    public int roundNumber; //un round è il numero del giro dei turni
    public int turnNumber;
    public Text playerText;

    // Start is called before the first frame update
    void Start()
    {
        playerToCall = 0;
        roundNumber = 1;
        turnNumber = 1;
        turnPlayer = gameData.turnOrder[playerToCall];
        playerText.text = turnPlayer.name;
        Debug.Log("giro: " + roundNumber + " Turno : " + turnNumber + " / " + turnPlayer.name + " è il tuo turno");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndTurn()
    {
        Debug.Log(turnPlayer.name + " ha finito turno " + turnNumber);
        playerToCall +=1;
        if(playerToCall >= gameData.turnOrder.Count)
        {
            roundNumber++;
            playerToCall = 0;
        }
        turnPlayer = gameData.turnOrder[playerToCall];
        playerText.text = turnPlayer.name;
        turnNumber++;
        Debug.Log("giro: " + roundNumber + " Turno : " + turnNumber +" / "+ turnPlayer.name + " è il tuo turno");
    }


}
