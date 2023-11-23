using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop_Alcohol : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler

{
    public FillGlass fillGlass;

    public Image firstFloor;
    public Image secondFloor;
    public Image thirdFloor;

    public Text top_Text;
    public Text middle_Text;
    public Text bottom_Text;

    public Image publicImage;

    public DragandDrop draganddrop;

    public Transform pouring_tr;
    public Transform pouring_slime_tr;
    private bool judge_tr = false;

    public float rotationSpeed = 200.0f;

    public GameObject[] dropArea; // 이미지가 놓여져야할 공간 범위(드래그해서 이미지를 감지할)
    public GameObject slime;

    public GameObject Panel;

    private bool isRotating;
    public static Vector2 DefaultPos;
    public static Quaternion DefaultRot;

    private RectTransform dropArea_;
    private RectTransform dropArea_slime;
    private Image slime_image;

    private string GlassName;
    public string alcoholName="red";
    

    void Start()
    {
        publicImage = publicImage.GetComponent<Image>();
        dropArea_slime = slime.GetComponent<RectTransform>();
        slime_image = slime.GetComponent<Image>();
    }
    private void Update()
    {
        for(int i = 0; i< dropArea.Length; i++)
        {
            bool isActive = dropArea[i].activeSelf;

            if (isActive)
            {
                dropArea_ = dropArea[i].GetComponent<RectTransform>();

            }
                    
        }
      
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그시작
    {
        DefaultPos = this.transform.position; //시작위치 저장
        DefaultRot = this.transform.rotation;
    }

    void IDragHandler.OnDrag(PointerEventData eventData) //드래그 중
    {
        
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // 드래그가 끝나고
    {
        Panel.SetActive(false);
        Vector2 dropPosition = eventData.position;

        if (draganddrop.GetChildrenActive_glass()) {
            
             if (RectTransformUtility.RectangleContainsScreenPoint(dropArea_, dropPosition)) //특정위치에 드래그한 이미지가있으면 
                {
            
                    
                     StartCoroutine(RotateObject(gameObject.transform));
                    






            }
            else if(RectTransformUtility.RectangleContainsScreenPoint(dropArea_slime, dropPosition))
            {
<<<<<<< HEAD
                    judge_tr = true; // 슬라임 위치인지 메인 잔 위치인지 판단해주는 
                    StartCoroutine(RotateObject(gameObject.transform));
                    
                    GameManager.instance.ResetValue(); //리셋시킴

                    ResetShaker();
=======
                    judge_tr = true;
                    StartCoroutine(RotateObject(gameObject.transform));
                    firstFloor.sprite = Resources.Load<Sprite>("Nothing");
                    secondFloor.sprite = Resources.Load<Sprite>("Nothing");
                    thirdFloor.sprite = Resources.Load<Sprite>("Nothing");

                    top_Text.text = "";
                    middle_Text.text = "";
                     bottom_Text.text = "";
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3

                    

            }
            else
            {
                this.transform.position = DefaultPos;
            }
        }
        else
        {
            this.transform.position = DefaultPos;
        }

        
    }

    private IEnumerator RotateObject(Transform tr)
    {
        if(judge_tr)
        {
            Sprite newSprite = Resources.Load<Sprite>("IceSlime_Open");
            tr.position = pouring_slime_tr.position;
            slime_image.sprite = newSprite;
            Debug.Log(newSprite);
            Debug.Log(slime_image.sprite);

        }
        else
        {
           
        
        tr.position = pouring_tr.position;

        }
        
        StartRotation();
        int i = 0;
        // 시간에 따라 게임 오브젝트를 회전

        while (isRotating)
        {

           
            if (i > 30)
            {
                isRotating = false;
            }

            ++i;
            float rotationAmount = rotationSpeed * Time.deltaTime;
            tr.Rotate(Vector3.forward, rotationAmount); // 2D 게임에서는 forward 축을 사용하여 회전
            yield return new WaitForSeconds(0.05f);

            

        }

        if (judge_tr)
        {
           
            judge_tr = false;
            slime_image.sprite = Resources.Load<Sprite>("iceSlime");
        }
        else
        {
            GlassName = publicImage.sprite.name;
            fillGlass.ResourcesChange(GlassName, alcoholName);
        }

        this.transform.position = DefaultPos;
        this.transform.rotation = DefaultRot;

    }

    public void StartRotation()
    {
        isRotating = true;
    }

  public void PanelSetActive()
    {
        if (Panel.activeSelf){
            Panel.SetActive(false );
        }
        else
        {
            Panel.SetActive(true);
        }
    }

<<<<<<< HEAD
    public void ResetShaker()
    {
        firstFloor.sprite = Resources.Load<Sprite>("Nothing");
        secondFloor.sprite = Resources.Load<Sprite>("Nothing");
        thirdFloor.sprite = Resources.Load<Sprite>("Nothing");

        top_Text.text = "";
        middle_Text.text = "";
        bottom_Text.text = "";
    }
=======
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
}
