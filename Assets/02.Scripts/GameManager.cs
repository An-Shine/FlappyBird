using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance; // gamemanager�� �� ������Ʈ ��𼭵� ���� �����ϰ� �ϱ����� static
    public bool isDead = false; //������ ������ �˾ƺ������� ����, ó���� �����ʾ����� false
    public bool isReady = true; // ó�����۽ÿ� ������ �ٷ� ���۵����ʰ� �غ�ȭ���� ���̱� ����
    public int mainScore = 0; //ȭ�� �߾ӿ� ���̴� ���ھ� ���� ����
    public float pipeCreateDelay = 1.5f; //�������� ���� ���� �Ǵ� �ð�

    // ���ӿ�����Ʈ ��������

    public GameObject pipe; //������ų ������ ������ ����
    public GameObject time_Panel; // titlePanel ����
    public GameObject gameover_Panel; // gameover_Panel ����
    public GameObject New_Img; // ���ο� Best Score�� ���ŵɶ� �����ֱ����� ����

    //�������
    public AudioClip pointSound; //������� ����
    public AudioClip dieSound; //�״� ����

    //�ؽ�Ʈ ���� ����

    public TextMeshProUGUI mainScore_Text; // ����ȭ�� ��� ����
    public TextMeshProUGUI finalScore_Text;  // ���ӿ���ȭ�� ��� final ����
    public TextMeshProUGUI bestScore_Text;  // ���ӿ��� ȭ�� bestScore ����

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
