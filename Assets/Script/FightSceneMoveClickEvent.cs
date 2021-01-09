using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FightSceneMoveClickEvent : MonoBehaviour
{
    EnemySetfightSceneMoving enemyMoving;
    public GameObject EnemySet;
    // Start is called before the first frame update
    void Start()
    {
        enemyMoving = EnemySetfightSceneMoving.enemyset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {

        SceneManager.LoadScene("fight_scene");
    }
}
