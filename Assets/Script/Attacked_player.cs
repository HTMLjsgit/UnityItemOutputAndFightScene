using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacked_player : MonoBehaviour
{
    playerStatus player_status;
    // Start is called before the first frame update
    void Start()
    {
        player_status = playerStatus.player_status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        player_status.PlayerHPDown(10);
    }
}
