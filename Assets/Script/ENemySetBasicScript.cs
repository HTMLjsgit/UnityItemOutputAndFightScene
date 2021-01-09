using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ENemySetBasicScript : MonoBehaviour
{
    public static ENemySetBasicScript enemyscript;
    Fightscene_finish_obj finish_scene;
    // Start is called before the first frame update
    void Start()
    {
        finish_scene = Fightscene_finish_obj.fight_scene_finish;
    }
    private void Awake()
    {
        enemyscript = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.gameObject.transform.HasChild())
        {
            finish_scene.Finish();

        }
    }
}
