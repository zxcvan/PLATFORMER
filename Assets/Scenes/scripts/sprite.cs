using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    [SerializeField] private float speed; //�������� ������������
    [SerializeField] private int lives; //���-�� ������
    [SerializeField] private float jumpF; //���� ������

    private Rigidbody2D phisics;
    private SpriteRenderer sprite0;

    private const string Horisontal = nameof(Horisontal);
    private const string Vertical = nameof(Vertical);


    private void Awake()
    {
        phisics = GetComponent<Rigidbody2D>();
        sprite0 = GetComponentInChildren<SpriteRenderer>();
    }

    private void Run() //����������� ����� � �����
    {
        float direction = Input.GetAxis(Horisontal);
        float distance = direction * speed *;
    }

    void Update()
    {
            Run();  
    }
}
