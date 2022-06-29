using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerHelper : NetworkBehaviour
{
	GameHelper  __gameHelper;
    // Start is called before the first frame update
    void Start()
    {
    	__gameHelper = GameObject.FindObjectOfType<GameHelper>();
    	if(isLocalPlayer)
    	{
    		__gameHelper.CurrentPlayer = this;
    	}
        
    }

    [Command]
    public void CmdSend(string message)
    {
    	Debug.Log("Send =" + message);
    	RpcSend(message);
    }

    [ClientRpc]
    public void RpcSend(string message)
    {
    	__gameHelper.TextBlock.text += System.Environment.NewLine + message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
