using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Impostazioni della partita")]
    public int totalPlayersNumber; //Quanti players ci sono nella partita

    [Header("Non toccare pls")]
    public List<Player> playersInGame;
    public List<Player> allPossiblePlayers;
    private int playersCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetPlayers();
        Debug.Log(totalPlayersNumber);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetPlayers()
    {
        playersInGame.Clear();
        playersCount = 0;

        if(totalPlayersNumber <=2)
        {
            totalPlayersNumber = 2;
        }else
        if(totalPlayersNumber >= 8 /*allPossiblePlayers.Count*/)
        {
            totalPlayersNumber = 8 /*allPossiblePlayers.Count*/;
        }





        for (int i = 0; i <= totalPlayersNumber; i++)
        {
            playersInGame.Add(allPossiblePlayers[i]);
        }

        foreach (Player player in playersInGame)
        {

            player.playerNum = playersCount + 1;
            player.isAlive = true;
            playersCount++;
        }
        playersInGame[0].isHuman = true;

        if (playersCount == totalPlayersNumber)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        Debug.Log("Gioco Iniziato");
    }
}
