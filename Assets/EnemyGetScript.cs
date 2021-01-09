using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyGetScript : MonoBehaviour
{
    public static EnemyGetScript enemy_get_script;
    public bool destroy = false;
    private bool col = false;
    private bool destroy_basic_mode = true;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += SceneLoaded;


    }
    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        if (nextScene.name == "ItemSetStart")
        {
            if (destroy)
            {
                Destroy(this.gameObject);
            }
            if (destroy_basic_mode)
            {
                Destroy(this.gameObject);
            }
        }
        else if(nextScene.name == "fight_scene")
        {

        }
    }
    public static EnemyGetScript Instance
    {
        get; private set;
    }
    private void Awake()
    {
        enemy_get_script = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (col)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                destroy_basic_mode = true;
                DontDestroyOnLoad(this.gameObject);

            }

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            col = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            col = false;
        }
    }
}
