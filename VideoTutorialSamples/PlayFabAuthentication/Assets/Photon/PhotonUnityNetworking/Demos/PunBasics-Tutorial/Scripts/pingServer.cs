using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class pingServer : MonoBehaviour
{
	public string pingLatency = "-1";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pingLatency = PhotonNetwork.GetPing().ToString();
	}
}
