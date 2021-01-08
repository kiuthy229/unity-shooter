using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject _bullet;
    public Transform _attackPoint;
    public float _attackTime = 0.5f;
    private float _nextBulletTime;
    public float _speed;
    public GameObject _explosion;
    // Start is called before the first frame update
    void Start()
    {
        _nextBulletTime = Time.time + _attackTime;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }
    void Attack()
    {
        if (Time.time > _nextBulletTime)
        {
            Instantiate(_bullet, _attackPoint.position, Quaternion.identity);
            _nextBulletTime += _attackTime;
        }
    }
    void Move()
    {
        Vector3 pos = transform.position;
        pos.y -= _speed * Time.deltaTime;
        transform.position = pos;
        if (transform.position.y < -4f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet" || target.tag == "Enemy")
        {
            gameObject.SetActive(false);
            var explos = Instantiate(_explosion, transform.position, transform.rotation);
            Destroy(explos,0.14f);
        }
    }
}
