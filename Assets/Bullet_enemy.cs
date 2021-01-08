using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_enemy : MonoBehaviour
{
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 pos = transform.position;
        pos.y -= _speed * Time.deltaTime;
        transform.position = pos;
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player" || target.tag == "EnemyBullet")
        {
            Destroy(gameObject);
        }
    }
}
