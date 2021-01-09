using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerStatus : MonoBehaviour
{
    public GameObject MenuImage;
    public static playerStatus player_status;
    public int HP = 100;
    public int MP = 100;

    public int HPMAX;
    public int MPMAX;
    private ItemDataBase itemdata;
    public int player_power = 1;
    public int player_defense = 1;
    private bool display_mode = false;
    Slider slider;
    silider_get_script slider_get;
    DefenseTextGetScript defense_text;
    PowerTextGetScript power_text;
    retryGame retry_game;
    Center_get_script center_get;
    // Start is called before the first frame update
    void Start()
    {
        itemdata = ItemDataBase.item_base;
        defense_text = DefenseTextGetScript.defense_text;
        power_text = PowerTextGetScript.power_text;
        center_get = Center_get_script.center_script;
        if(power_text != null)
        {
            TextSetStatus(player_power.ToString(), player_defense.ToString());
        }
        retry_game = retryGame.retry_game;
        SliderChange(HP);
        SceneManager.sceneLoaded += SceneLoaded;
    }
    private void Awake()
    {
        player_status = this;
    }

    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
       if(nextScene.name == "ItemSetStart")
        {
            SliderChange(HP);
        }else if(nextScene.name == "fight_scene")
        {
            SliderChange(HP);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (MenuImage != null)
            {
                MenuDisplay();

            }
        }
    }

    public void GearReset()
    {
        playerGear(10, 0);
    }
    private void MenuDisplay()
    {
        if(display_mode == false)
        {
            //MenuImage.gameObject.GetComponent<RectTransform>().transform.position = new Vector2(MenuImage.transform.position.x, MenuImage.transform.position.y - 1020);
            MenuImage.GetComponent<Animator>().SetBool("move", true);
            if (Center_get_script.center_script.gameObject.HasChild())
            {
                Center_get_script.center_script.gameObject.transform.GetChild(0).GetComponent<Button>().Select();
            }
            this.gameObject.GetComponent<playerMoveController>().enabled = false;
            this.gameObject.GetComponent<player_colider>().enabled = false;
            retry_game.Pause(false);

            display_mode = true;

        }
        else
        {
            //MenuImage.gameObject.GetComponent<RectTransform>().transform.position = new Vector2(MenuImage.transform.position.x, MenuImage.transform.position.y + 1020);
            
            MenuImage.GetComponent<Animator>().SetBool("move", false);
            this.gameObject.GetComponent<playerMoveController>().enabled = true;
            this.gameObject.GetComponent<player_colider>().enabled = true;
            retry_game.Pause(true);

            display_mode = false;

        }
    }
    public void HPIncrease(int item_increase_hp, GameObject gbj, ItemList item)
    {
        if(HP < HPMAX)
        {
            HP += item_increase_hp;

            Destroy(gbj);
            Select_transform_go();

            itemdata.items.Remove(item);
            SliderChange(HP);
        }
    }
    public void MPIncrease(int item_increase_mp, GameObject gbj, ItemList item)
    {
        if(MP < MPMAX)
        {
            MP += item_increase_mp;
            Destroy(gbj);
            Select_transform_go();

            itemdata.items.Remove(item);
           // SliderChange(item_increase_mp);

        }
    }

    public void playerGear(int power, int defense)
    {
            player_power = power;
            player_defense = defense;
            TextSetStatus(power.ToString(), defense.ToString());

           
    }

    public void PlayerHPDown(int hp_decrease)
    {
        if(HP > 0)
        {
            HP -= hp_decrease;

            SliderChange(HP);
            if (HP <= 0)
            {
                Debug.Log("ゲームオーバー");
            }
        }

    }

    public void TextSetStatus(string power, string defense)
    {
        if(power_text != null)
        {
            power_text.GetComponent<Text>().text = "攻撃力:" + power;
            defense_text.GetComponent<Text>().text = "防御力:" + defense;
        }
          
    }

    public void Select_transform_go()
    {
        if (center_get != null)
        {
            center_get.gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().Select();
        }
    }
    public void SliderChange(int value)
    {
        slider_get = silider_get_script.slider_script;
        Debug.Log(slider_get);
        slider = slider_get.GetComponent<Slider>();
        slider.value = value / 100f;

    }
}
