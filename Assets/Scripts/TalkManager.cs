using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;



public class TalkManager : MonoBehaviour
{
    public TopbarChange topbarChange;
    public MakingAlcohol makingAlcohol;

    Dictionary<int, string[]> talkData; //대화 딕셔너리<이벤트번호,대화 문자열>
    Dictionary<int, string[]> lasttalkData;//마지막 대화 딕셔너리
    string[] CharacterName = new string[99]; // 등장인물 이름 넣는 문자 배열

    public GameObject TalkPanel; //대화 팬넬
    public Text Talktext; // 대화 텍스트
    public Text nameText; // 네임 텍스트

    int talkIndex = 1; // 딕셔너리 인덱스번호 , 1인 이유는 0을 미리 실행하기 때문임
<<<<<<< HEAD
    [HideInInspector]
    public int randomIndex; // 이벤트 번호 == 캐릭터 인덱스 번호
    [HideInInspector]
=======
    public int randomIndex; // 이벤트 번호 == 캐릭터 인덱스 번호

>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
    public float curruntTime =18.0f; //현재 시간

    public GameObject characterImage; // 캐릭터 이미지 담아두는 곳
    public GameObject[] imagePrefabs; // 이미지 프리팹들을 저장할 배열
    public Transform spawnPoint; // 이미지가 출현할 위치

    public GameObject create_Alcohol;
    public GameObject barInside;

<<<<<<< HEAD
    [HideInInspector]
    public bool flag = false; // 마지막 대사인지 아닌지 확인하는 깃발
    [HideInInspector]
=======
    public bool flag = false; // 마지막 대사인지 아닌지 확인하는 깃발
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
    public bool finishedMakingAlcoholFlag = false; //알콜 주조가 끝났는지 확인하는 깃발

    public float delay = 0.06f; // 글자가 나오는 딜레이 속도
    private bool coroutineIsRunningFlag =true; //글자가 나오고 있는지 확인하는 깃발

    public Button bell_btn;
    public Button door_btn;



    void Awake()
    {
        talkData = new Dictionary<int, string[]>(); // 대화 데이터를 넣는 딕셔너리 (이벤트번호, 대화배열)
        lasttalkData = new Dictionary<int, string[]>(); // 마지막 대화 데이터 넣는 딕셔너리
        GenerateData();

      
    }

    private void Update()
    {
        if (finishedMakingAlcoholFlag)
        {
            string lasttalk = GetlastTalk(randomIndex, 0); // 마지막대사를 대화창에 띄우고
            StartCoroutine(textPrint(lasttalk)); // 점차나오는 텍스트
            finishedMakingAlcoholFlag = false;
        }
    }


    public void ImageCreating()
    {
        

        if (imagePrefabs.Length > 0)
        {
            Talktext.text = "";
            while (true)
            {
                int check = randomIndex;
                randomIndex = Random.Range(0, imagePrefabs.Length);  
                if (check != randomIndex) break; //전에 거와 같은 이미지가 나오면 배제함
                
            }                       
            // 선택한 이미지 프리팹을 화면에 띄우기
            characterImage = Instantiate(imagePrefabs[randomIndex], spawnPoint.position, Quaternion.identity); //이미지 생성
<<<<<<< HEAD
            StartCoroutine(ImageMoving(characterImage));


            nameText.text = CharacterName[randomIndex];// 이름 텍스트에 인덱스에 맞는 이름 넣음

           

            
=======

            nameText.text = CharacterName[randomIndex];// 이름 텍스트에 인덱스에 맞는 이름 넣음

            string firstTalk = GetTalk(randomIndex, 0); // 첫번째 텍스트를 띄움
            coroutineIsRunningFlag = false;
            StartCoroutine(textPrint(firstTalk));

>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
            bell_btn.interactable = false;
            door_btn.interactable = false;
        }
        else
        {
            Debug.LogError("이미지 프리팹 배열이 비어있습니다.");
        }
    }

    // Update is called once per frame
    void GenerateData() //대화배열에 대화를 넣는 함수
    {
        CharacterName[0] = "Elf";
        CharacterName[1] = "Cargirl";
        CharacterName[2] = "MarketOner";

        // 반드시 한칸씩 띄워서 작성할 것!
<<<<<<< HEAD
        talkData.Add(0, new string[] { "안녕 아이콜 오랜만이네?" , " 마가리타 부탁해 이 세상에서 제일 시원하게!"," 라임슬라이스 잊지 말고!"
=======
        talkData.Add(0, new string[] { "Elf111111111" , " Elf222222222"," Elf333333333333"
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
            });
        talkData.Add(1, new string[] { "cat111" , " cat22222", " cat33333", " cat4444" });
        talkData.Add(2, new string[] { "MarketOner1111111", " MarketOner22", " MarketOner33333", " MarketOner4444" });

<<<<<<< HEAD
        lasttalkData.Add(0, new string[] { "와 정말 최고였어!" , "음 이정도면 괜찮아" , "우웩 이게 뭐야 최악이야!" });
=======
        lasttalkData.Add(0, new string[] { "오 정말 고마워요" });
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
        lasttalkData.Add(1, new string[] { "내 생에 최고의 술이였어" });
        lasttalkData.Add(2, new string[] { "정말 만족스러운데? 고마워" });
    }
    
    public string GetTalk(int number , int talkIndex) // talkData의 index의 대화를 리턴해주는 함수
    {
        if (talkIndex == talkData[number].Length)
            return null;
        else    
            return talkData[number][talkIndex];
    }

    public string GetlastTalk(int number, int talkIndex) // lasttalkData의 index의 대화를 리턴해주는 함수
    {
        if (talkIndex == lasttalkData[number].Length)
            return null;
        else
            return lasttalkData[number][talkIndex];
    }

    public void Talking()
    {
<<<<<<< HEAD
        if (GameManager.instance.timeFlag) // 시간이 지나 flag가 false가 되면 작업을 수행하지 않는다.
=======
        if (TopbarValue.instance.timeFlag) // 시간이 지나 flag가 false가 되면 작업을 수행하지 않는다.
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
        {
             // 대사 출력이 시작되어 트루로 바꿈

            if (flag)
            {

                // 깃발이 트루이면 마지막 버튼을 누를때 이미지를 파괴시키고 다시 새로운 이미지를 띄움
                Destroy(characterImage); characterImage = null; //이미지 파괴후 초기화
                TalkPanel.SetActive(false); // 토크펜넬 없에고
                Invoke("ImageCreating", 2f); // 이미지 재생성
<<<<<<< HEAD
                
=======
                Invoke("RepeatPanel", 2f); // 펜넬 Active
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
                flag = false; // 깃발 false
                talkIndex = 1; // 인덱스 1로 다시 바꿈


            }

            else
            {
                if (coroutineIsRunningFlag) //대화 출력이 끝나지 않으면 다음 대화를 띄우지 않음 
                { 
                    string talkData = GetTalk(randomIndex, talkIndex); //받아온 대화를 저장

                    if (talkData == null) // 대화가 끝나면 대화창을 닫음
                    {
                        talkIndex = 1;
    
                        ChangePlace(); // 조주화면으로 변경

    
                        TalkPanel.SetActive(false);
                        characterImage.SetActive(false);

                }
                    else {
                
                        coroutineIsRunningFlag = false;
                        StartCoroutine(textPrint(talkData));//대화창에 대화를 넣는다.
                        
                        }

                talkIndex++;
                Talktext.text = "";
                }

                else
                {


                }
            }
        }
        else //있던 이미지를 파괴하고 대화창을 비활성화 시킨다(날짜가 지날때)
        {
            TalkPanel.SetActive(false);
            flag = false; // 깃발 false
            Destroy(characterImage); characterImage = null;
            talkIndex = 1; // 인덱스 1로 다시 바꿈
            bell_btn.interactable = true;
            door_btn.interactable = true;
            topbarChange.DayGain(); 
        }
<<<<<<< HEAD

    }
    
    public void ChangePlace() // 가게 -> 조주 화면 교체
    {
        barInside.SetActive(false);
        create_Alcohol.SetActive(true);
    }

    public void ChangePlace_R() // 조주 -> 가게 화면 교체
    {
        barInside.SetActive(true);
        create_Alcohol.SetActive(false);
    }

    public IEnumerator textPrint( string txt) // 텍스트를 한글자씩 나오게하는 함수
    {
        int count = 0;

        while (count != txt.Length)
        {
            if (count < txt.Length)
            {
                Talktext.text += txt[count].ToString();
                
                count++;
            }

            yield return new WaitForSeconds(delay);
        }

        coroutineIsRunningFlag = true;

    }

    public IEnumerator ImageMoving(GameObject gameImage)
    {
        float speed = 70f;
        while (gameImage.transform.position.y < 2.78) { 
        gameImage.transform.Translate(Vector3.up * speed * Time.deltaTime);
            speed += 2;
        yield return new WaitForSeconds(0.01f);

        }

        TalkPanel.SetActive(true );
        coroutineIsRunningFlag = false;
        string firstTalk = GetTalk(randomIndex, 0); // 첫번째 텍스트를 넣음
        StartCoroutine(textPrint(firstTalk));
=======
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3

    }
    void RepeatPanel() // 펜넬 다시 띄우는 함수
    {
        TalkPanel.SetActive(true);
    }
    public void ChangePlace() // 가게 -> 조주 화면 교체
    {
        barInside.SetActive(false);
        create_Alcohol.SetActive(true);
    }

    public void ChangePlace_R() // 조주 -> 가게 화면 교체
    {
        barInside.SetActive(true);
        create_Alcohol.SetActive(false);
    }

    public IEnumerator textPrint( string txt) // 텍스트를 한글자씩 나오게하는 함수
    {
        int count = 0;

        while (count != txt.Length)
        {
            if (count < txt.Length)
            {
                Talktext.text += txt[count].ToString();
                
                count++;
            }

            yield return new WaitForSeconds(delay);
        }

        coroutineIsRunningFlag = true;

    }


}
