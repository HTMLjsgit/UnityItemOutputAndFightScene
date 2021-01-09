using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class buttton_select_then_script : MonoBehaviour
{
    private Button _button;
    public KeyCode _key;
    public static buttton_select_then_script button_script;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();

    }

    private void Awake()
    {
        button_script = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select()
    {
        if (Input.GetKeyDown(_key))
        {
            _button.onClick.Invoke();
        }
    }

    public void Deselect()
    {

    }

    public void Select_go()
    {
        _button.Select();

    }
}
