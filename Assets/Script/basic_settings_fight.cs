using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basic_settings_fight : MonoBehaviour
{
    public static basic_settings_fight basic;
    public GameObject EnemySet;
    EnemySetfightSceneMoving enemymoving;
    enemy_parameter_set set;
    playerStatus player;
    ItemImageGetScript ItemGetScript;
    public Button button;
    ItemDataBase item_base;
    public GameObject ItemIcon;
    public GameObject Center_objes;
    MessageSetScript message_set;
    // Start is called before the first frame update
    void Start()
    {
        message_set = MessageSetScript.message_set;
        enemymoving = EnemySetfightSceneMoving.enemyset;
        EnemyObjectSet(enemymoving.objes);
        set = enemy_parameter_set.set;
        player = playerStatus.player_status;
        player.GetComponent<player_colider>().enabled = false;
        player.GetComponent<playerMoveController>().enabled = false;
        button.Select();
        item_base = ItemDataBase.item_base;
        ItemGetScript = ItemImageGetScript.item_image_script;
        foreach(ItemList item in item_base.items)
        {
            GameObject g = Instantiate(ItemIcon, Center_objes.transform.position, Quaternion.identity, Center_objes.transform);
            if (item.image != null)
            {
                //g.GetComponent<Image>().sprite = Sprite.Create(item.itemIcon, new Rect(0, 0, item.itemIcon.width, item.itemIcon.height), Vector2.zero);
                g.GetComponent<Image>().sprite = item.image;
            }

            g.GetComponent<ItemIconClickScript>().item = item;
        }
        message_set.MessageSet("敵が#{enemy_count}体現れた！");
        //foreach()
    }
    private void Awake()
    {
        basic = this;
    }
    public void EnemyObjectSet(GameObject[] enemy)
    {
        int x = 0;
        //enemy_set_go[0].gameObject.GetComponent<Selectable>().Select();
        foreach (GameObject enemy_g in enemy)
        {
            GameObject g = Instantiate(enemy_g, EnemySet.transform.position, Quaternion.identity, EnemySet.transform);
            g.GetComponent<Image>().sprite = enemy_parameter_set.set.enemy_image[x];
            g.GetComponent<EnemySetImage>().EnemySet(enemy_parameter_set.set.HP[x], enemy_parameter_set.set.power[x], enemy_parameter_set.set.defense[x]);
            x++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
