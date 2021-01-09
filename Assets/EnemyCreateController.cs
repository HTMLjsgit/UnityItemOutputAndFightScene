using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreateController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public int[] EnemyAllNumber;
    public Vector3[] EnemyBasicTransformPosition;
    private int x = 0;
    void Start()
    {

        for(int i = 0; i < EnemyAllNumber[0]; i++)
        {
            Instantiate(obj, EnemyBasicTransformPosition[x], Quaternion.identity);
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
