using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyChildFindScript : MonoBehaviour
{
    DontDestroyChildFindScript dont_destroy_child_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        dont_destroy_child_script = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
