using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LanguetteAxeX : MonoBehaviour
{
    [SerializeField] private GameObject imageLang = null;


    public void DragLang(BaseEventData data)
    {
        Vector3 decalPosX = new Vector3(0f, Input.touches[0].deltaPosition.x, 0f);
        transform.position += decalPosX;
        imageLang.transform.position += decalPosX;
        Debug.Log("toooooooooooo");
    }

}