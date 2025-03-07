using UnityEngine;
using UnityEngine.UI;//UI관련 라이브러리
using UnityEngine.SceneManagement;// 씬 관리 관련 라이브러

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;// 게임 오버시 활성화 할 텍스트 게임 오브젝트
    public Text timeText; // 생존시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고기록을 표시할 텍스트컴포넌트

    private float surviveTime; //생존시간
    private bool isGameover; //게임오버 상태
    

    void Start()
    {
        //생존 시간과 게임오버 상태 초기화
        surviveTime = 0;
        isGameover = false;
        
    }

    void Update()
    {
        //게임오버가 아닌 동안
        if (!isGameover)
        {
            // 생존시간 갱신
            surviveTime += Time.deltaTime;
            // 갱신한 생존시간을 timeText 텍스트 컴포넌트를 이용해 표시
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //게임 오버 상태에서 R키를 누른경우
                SceneManager.LoadScene("SampleScenc");
            }
        }
    }
    
    public void EndGame()
    {

    }
}
