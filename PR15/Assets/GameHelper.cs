using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public InputField Input;
    public Text TextBlock;

    private PlayerHelper __currentPlayer;

    public PlayerHelper CurrentPlayer
    {
    	get { return __currentPlayer; }
    	set { __currentPlayer = value; }
    }

    public void Send()
    {
    	CurrentPlayer.CmdSend(Input.text);
    }
}
