using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retryGame : MonoBehaviour
{
    public bool on_set;
    public KeyCode key_code;
    public static retryGame retry_game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        retry_game = this;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Pause(bool set)
    {

            foreach (Transform trans in this.gameObject.transform)
            {
                trans.gameObject.SetActive(set);
            }


    }
}
