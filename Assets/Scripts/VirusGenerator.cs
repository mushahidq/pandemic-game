using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGenerator : MonoBehaviour
{

    float x = 0;
    float y = 0;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        int a = (int) Random.Range(0, 10);
        pos = new Vector2(x, y);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
