using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemies()
    {
        float pos_X = Random.Range(-3.5f,3.5f);
        Vector3 pos = transform.position;
        pos.x = pos_X;
        //if (Random.Range(0, 2) > 0)
        {
            Instantiate(_enemy, pos, Quaternion.Euler(0f, 0f, 180f));
            Invoke("SpawnEnemies", 2f);
        }
      
    }
}
