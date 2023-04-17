using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool empty = true;

    public Transform slotIconGameObject;

    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {
        item.GetComponent<Item>().ItemUsage();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UseItem();
    }
}
