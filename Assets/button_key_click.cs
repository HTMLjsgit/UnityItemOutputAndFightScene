using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button_key_click : MonoBehaviour
{
    public KeyCode _key;
    private Animator anim;
    private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Selected"))
            {
                _button.onClick.Invoke();
            }
        }
    }

}
