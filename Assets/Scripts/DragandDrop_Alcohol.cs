using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop_Alcohol : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler

{
    public FillGlass fillGlass;

    public Image publicImage;

    public DragandDrop draganddrop;
    public Transform pouring_tr;

    public float rotationSpeed = 200.0f;

    public GameObject[] dropArea; // 이미지가 놓여져야할 공간 범위(드래그해서 이미지를 감지할)

    private bool isRotating;
    public static Vector2 DefaultPos;
    public static Quaternion DefaultRot;

    private RectTransform dropArea_;

    private string GlassName;
    public string alcoholName="red";
    

    void Start()
    {
        publicImage = publicImage.GetComponent<Image>();
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

        Vector2 dropPosition = eventData.position;

        if (draganddrop.GetChildrenActive_glass()) {
            
             if (RectTransformUtility.RectangleContainsScreenPoint(dropArea_, dropPosition)) //특정위치에 드래그한 이미지가있으면 
                {
            

                     StartCoroutine(RotateObject(gameObject.transform));

            

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
        tr.position = pouring_tr.position;
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

        GlassName = publicImage.sprite.name;

        
        fillGlass.ResourcesChange(GlassName, alcoholName);

        this.transform.position = DefaultPos;
        this.transform.rotation = DefaultRot;

    }

    public void StartRotation()
    {
        isRotating = true;
    }

  

}
