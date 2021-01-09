using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class select_mode : MonoBehaviour
{
    public static select_mode select;
    Attack_player_button attack_player_button;
    public KeyCode enter_key;
    public KeyCode decrease_key;
    // Start is called before the first frame update
    void Start()
    {
        attack_player_button = Attack_player_button.attack_player_button;

    }
    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void click()
    {
        attack_player_button.AttackDo(this.gameObject);
    }
    public void select_z()
    {
        if (Input.GetKeyDown(enter_key))
        {
            attack_player_button.AttackDo(this.gameObject);
        }
        if (Input.GetKeyDown(decrease_key))
        {
            buttton_select_then_script.button_script.GetComponent<Button>().Select();
        }
    }
}
