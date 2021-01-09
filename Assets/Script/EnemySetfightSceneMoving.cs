using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetfightSceneMoving : MonoBehaviour
{
    public GameObject[] objes;
    public static EnemySetfightSceneMoving enemyset;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Awake()
    {
        enemyset = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] Set()
    {
        return objes;
    }
}
