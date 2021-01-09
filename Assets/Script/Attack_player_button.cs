using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Attack_player_button : MonoBehaviour
{
    playerStatus player_status;
    GameObject EnemySet;
    ENemySetBasicScript enemy_script;
    float sleep_time;
    public float wait_time;
    float x;
    float y;
    Button _button;
    public static Attack_player_button attack_player_button;
    // Start is called before the first frame update
    void Start()
    {

        player_status = playerStatus.player_status;
        enemy_script = ENemySetBasicScript.enemyscript;
        EnemySet = enemy_script.gameObject;
        _button = GetComponent<Button>();
        Attack_flow_end();
    }
    private void Awake()
    {
        attack_player_button = this;
    }
    // Update is called once per frame
    void Update()
    {
        sleep_time += Time.deltaTime;
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }
    public void Attack()
    {
            AttackScript();

        //player_status.player_power;
    }
    public void AttackDo(GameObject gbj)
    {
            if (EventSystem.current.currentSelectedGameObject == gbj)
            {
                gbj.GetComponent<EnemySetImage>().EnemyAttacked(player_status.player_power);
                MessageSetScript.message_set.MessageSet("敵を攻撃した。");
                    PlayerAttacked();
            }

    }
    public void PlayerAttacked()
    {
            foreach (Transform enemy in EnemySet.transform)
            {

                    EnemySetImage enemy_set = enemy.gameObject.GetComponent<EnemySetImage>();
                    MessageSetScript.message_set.MessageSet("敵を攻撃した。");
                    enemy_set.PlayerAttack(enemy_set.power);
            }
        Attack_flow_end();

    }


    public void Attack_flow_end()
    {
        _button.Select();
    }
    public void EnemySelected()
    {
        AttackScript();
    }
    private void AttackScript()
    {
        EnemySet.transform.GetChild(0).GetComponent<Selectable>().Select();
    }

}
