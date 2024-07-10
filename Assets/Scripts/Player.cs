using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject
{

    [Header("Informazioni")]
    public string playerName;
    public Material playerMateral;

    [Header("Non toccare pls")]
    public int playerNum = 0;
    public bool isHuman = false;
    public bool isAlive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
