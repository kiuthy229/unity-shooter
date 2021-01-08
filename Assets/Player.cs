using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject _bullet;
    public Transform _attackPoint;
    public float _attackTime = 0.5f;
    private float _nextBulletTime;
    public float _speed;
    public AudioSource _laser;
    // Start is called before the first frame update
    void Start()
    {
        _laser = GetComponent<AudioSource>();
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
            _laser.Play();
        }    
    }
    void Move()
    {
        Vector3 pos = transform.position;
        if (Input.GetAxisRaw("Vertical")>0f){
            pos.y +=_speed * Time.deltaTime;
            if (pos.y > 8.2f)
            {
                pos.y = 8.2f;
            }
            transform.position = pos;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            pos.y -=_speed * Time.deltaTime;
            if (pos.y < -8.5f)
            {
                pos.y = -8.5f;
            }
            transform.position = pos;
        }
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            pos.x +=_speed * Time.deltaTime;
            if (pos.x > 3.9f)
            {
                pos.x = 3.9f;
            }
            transform.position = pos;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            pos.x -=_speed * Time.deltaTime;
            if (pos.x <-4f)
            {
                pos.x = -4f;
            }
            transform.position = pos;
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
