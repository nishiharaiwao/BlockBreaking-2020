using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var obj = new GameObject[3*5];
        
        for(int y = 0; y < 3; y ++) {
            for(int x = 0; x < 5; x ++){
                obj[x + y * 5] = (GameObject)Resources.Load ("Block");
                Instantiate(obj[x + y * 5], new Vector3(-4.0f + (x * 2),0.0f,9.0f - y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
