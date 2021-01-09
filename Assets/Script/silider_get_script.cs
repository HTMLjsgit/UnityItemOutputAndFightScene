using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class silider_get_script : MonoBehaviour
{
    public static silider_get_script slider_script;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);

    }
    private void Awake()
    {
        slider_script = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
