using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllItem : MonoBehaviour
{
    private GameObject itemInfoView;//아이템 정보 출력창
    private Text itemInfoText;//아이템 정보 출력창의 GUIText
    private Item thisItem;//현재 아이템의 정보 저장

    private void Start()
    {
        // 오브젝트 생성후 이름 저장
        thisItem = new Item();
        thisItem.itemName = this.gameObject.name;

        // 아이템 정보 출력창을 확인
        itemInfoView = GameObject.Find("ItemInfoView");
        itemInfoText = itemInfoView.transform.Find("ItemInfoText").GetComponent<Text>();

        
    }

    public void OnClickedButton()
    {

        itemInfoText.text = thisItem.itemName + "\n" + thisItem.itemOption;

    }

    public class Item
    {
        public string itemName;
        public string itemOption = "NULL";
    }
}
