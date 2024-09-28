using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float BirdJump = 400.0f;
    public static Bird bird;
    public Vector3 LookDirection;
    public GameObject BirdImg;
    public float maxYValue = 10.0f;
    void Start()
    {
        bird = this;

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& this.transform.position.y <= 5f) // 0�� ���� ���콺 ��ư , this�� y�� 5.0f���Ϸ� ����
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; //���ӵ� 0�����ʱ�ȭ
            gameObject.GetComponent<Rigidbody>().AddForce(0f, BirdJump, 0f); //���οø��� (�� �߰�)
            GetComponent<AudioSource>().Play(); //�Ҹ�����

        }

        LookDirection.z = GetComponent<Rigidbody>().velocity.y * 10f + 20f; // y���� �ӵ��� �����ϸ� y���� +����
        Quaternion R = Quaternion.Euler(LookDirection); //z�� �߽����� z�� ȸ������ ��ȯ.
        BirdImg.transform.rotation = Quaternion.RotateTowards(BirdImg.transform.rotation, R, 5f);


        /*if (transform.position.y > maxYValue)
        {
             Y ��ǥ�� �ִ�ġ�� ����
            Vector3 position = transform.position;
            position.y = maxYValue;
            transform.position = position;

            // Rigidbody�� �ӵ��� 0���� �����Ͽ� �� �̻� �ö��� �ʵ��� ��
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            
        }*/

    }
}