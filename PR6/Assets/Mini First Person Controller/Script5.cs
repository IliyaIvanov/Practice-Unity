using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{
    private Vector3 MouseOffSet;
    private float MouseZCoord;

    //При нажатии клавиши мыши
    //происходит корректировка позиции

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        MouseOffSet = gameObject.transform.position - GetMousePosition();
    }
    
    //Получение координат курсора
    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = MouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    //Основная логика скрипта
    //смена позиции объекта относительно курсора
    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + MouseOffSet;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
