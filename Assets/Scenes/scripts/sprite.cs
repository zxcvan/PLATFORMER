using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    [SerializeField] private float speed; //скорость передвижения
    [SerializeField] private int lives; //кол-во жизней
    [SerializeField] private float jumpF; //сила прыжка

    private Rigidbody2D phisics;
    private SpriteRenderer sprite0;

    private const string Horisontal = nameof(Horisontal);
    private const string Vertical = nameof(Vertical);


    private void Awake()
    {
        phisics = GetComponent<Rigidbody2D>();
        sprite0 = GetComponentInChildren<SpriteRenderer>();
    }

    private void Run() //предвижение вперёд и назад
    {
        float direction = Input.GetAxis(Horisontal);
        float distance = direction * speed *;
    }

    void Update()
    {
            Run();  
    }
}
