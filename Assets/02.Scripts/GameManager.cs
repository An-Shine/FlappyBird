using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance; // gamemanager를 이 프로젝트 어디서든 접근 가능하게 하기위한 static
    public bool isDead = false; //게임이 끝났나 알아보기위한 변수, 처음엔 죽지않았으니 false
    public bool isReady = true; // 처음시작시에 게임이 바로 시작되지않고 준비화면을 보이기 위해
    public int mainScore = 0; //화면 중앙에 보이는 스코어 점수 변수
    public float pipeCreateDelay = 1.5f; //파이프가 생성 텀이 되는 시간

    // 게임오브젝트 변수관련

    public GameObject pipe; //생성시킬 파이프 프리팹 연결
    public GameObject time_Panel; // titlePanel 연결
    public GameObject gameover_Panel; // gameover_Panel 연결
    public GameObject New_Img; // 새로운 Best Score가 갱신될때 보여주기위한 변수

    //사운드관련
    public AudioClip pointSound; //점수얻는 사운드
    public AudioClip dieSound; //죽는 사운드

    //텍스트 관련 변수

    public TextMeshProUGUI mainScore_Text; // 게임화면 가운데 점수
    public TextMeshProUGUI finalScore_Text;  // 게임오버화면 가운데 final 점수
    public TextMeshProUGUI bestScore_Text;  // 게임오버 화면 bestScore 점수

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
