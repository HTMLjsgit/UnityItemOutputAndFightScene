using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_set : MonoBehaviour
{
    public static finish_set finish_set_script;
    public string[] finish_fight_message;
    public int exprience_point;
    // Start is called before the first frame update
    void Start()
    {
        foreach(string message in finish_fight_message)
        {
           message.Replace("#{ex_pt}", exprience_point.ToString());
        }
    }

    private void Awake()
    {
        finish_set_script = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
