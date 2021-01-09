using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MessageSetScript : MonoBehaviour
{
    public static finish_set finish_set;
    public static MessageSetScript message_set;
    [SerializeField] Text message_text;
    public KeyCode get_key;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        finish_set = finish_set.finish_set_script;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void Awake()
    {
        message_set = this;

    }

    public void FinishMessage(int x)
    {

        if (finish_set.finish_fight_message.Length <= x)
        {
            if (Input.GetKeyDown(get_key))
            {
                message_text.text = finish_set.finish_fight_message[x];
            }
        }
        x++;
    }

    public void MessageSet(string message)
    {
        string show_message;
        show_message = message.Replace("#{enemy_count}", ENemySetBasicScript.enemyscript.gameObject.transform.childCount.ToString());
        message_text.text = show_message;
    }
}
