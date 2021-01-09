using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemySetImage : MonoBehaviour
{
    public int HP;
    public int power;
    public int defense;
    public string texture_name;
    public static EnemySetImage enemy_image;
    playerStatus player_status;
    public Slider slider;
    public Text text_power;
    public Text text_defense;
    // Start is called before the first frame update
    void Start()
    {
        player_status = playerStatus.player_status;
        text_power.text = "攻撃力: " + power;
        text_defense.text = "防御力: " + defense;
    }

    private void Awake()
    {
        enemy_image = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemySet(int HP_set, int power_set, int defense_set)
    {
        HP = HP_set;
        power = power_set;
        defense = defense_set;
    }
    
    public void EnemyAttacked(int power_dec)
    {
 
        HP -= power_dec - defense;
        slider.value = HP / 100.0f;
        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayerAttack(int power_dec)
    {
        player_status.PlayerHPDown(power_dec - player_status.player_defense);
    }
}
