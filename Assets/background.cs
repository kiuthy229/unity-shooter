using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * _speed);
        GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
