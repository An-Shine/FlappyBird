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
        if (Input.GetMouseButtonDown(0)&& this.transform.position.y <= 5f) // 0은 왼쪽 마우스 버튼 , this의 y값 5.0f이하로 제한
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; //가속도 0으로초기화
            gameObject.GetComponent<Rigidbody>().AddForce(0f, BirdJump, 0f); //위로올리고 (힘 추가)
            GetComponent<AudioSource>().Play(); //소리내고

        }

        LookDirection.z = GetComponent<Rigidbody>().velocity.y * 10f + 20f; // y축의 속도가 증가하면 y값이 +가됨
        Quaternion R = Quaternion.Euler(LookDirection); //z축 중심으로 z축 회전값을 반환.
        BirdImg.transform.rotation = Quaternion.RotateTowards(BirdImg.transform.rotation, R, 5f);


        /*if (transform.position.y > maxYValue)
        {
             Y 좌표를 최대치로 설정
            Vector3 position = transform.position;
            position.y = maxYValue;
            transform.position = position;

            // Rigidbody의 속도를 0으로 설정하여 더 이상 올라가지 않도록 함
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            
        }*/

    }
}