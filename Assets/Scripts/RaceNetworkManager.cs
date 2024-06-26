using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceNetworkManager : NetworkManager
{
    [SerializeField] private Transform[] spawnPoints;
    public void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
      
        Vector3 spawnPoint = spawnPoints[numPlayers].position;
        var player = Instantiate(playerPrefab,spawnPoint,Quaternion.identity);
        NetworkServer.AddPlayerForConnection(conn,player);
    }
    
}
