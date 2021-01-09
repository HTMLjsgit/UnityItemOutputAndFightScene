using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fightscene_finish_obj : MonoBehaviour
{
    public static Fightscene_finish_obj fight_scene_finish;
    finish_set finish_set;
    playerStatus player;
    EnemyGetScript enemy_get;
    // Start is called before the first frame update
    void Start()
    {
        finish_set = finish_set.finish_set_script;
        player = playerStatus.player_status;
        enemy_get = EnemyGetScript.enemy_get_script;
    }

    private void Awake()
    {
        fight_scene_finish = this;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Finish()
    {
        player.GetComponent<player_colider>().enabled = true;
        player.GetComponent<playerMoveController>().enabled = true;
        EnemyGetScript.enemy_get_script.destroy = true;
        SceneManager.LoadScene("ItemSetStart");
    }

}
