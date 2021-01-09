using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGear : MonoBehaviour
{
    playerStatus playerStatus;
    public KeyCode keycode;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus = playerStatus.player_status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        Debug.Log("Reset!");

        playerStatus.GearReset();
    }

    public void OnSelect()
    {
        if (Input.GetKeyDown(keycode))
        {
            this.gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
