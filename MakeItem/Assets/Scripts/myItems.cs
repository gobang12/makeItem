using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myItems : MonoBehaviour
{
    private Transform Parent;//ItemListView의 SetOption 지정시 사용
    private GameObject newItemObject;// 새로 만들어질 오브젝트
    public GameObject originPrefab;// 새로 만들어질 오브젝트의 프리팝
    private Text itemNameText;// 새로 만들어질 오브젝트의 GUIText
    public List<GameObject> itemBox;// 아이템들이 저장될 리스트

    private string[] prefix1 ={ "a","b","c","d","e","f","g","h","i","j",
            "aa", "bb", "cc", "dd", "ee", "ff", "gg", "hh", "ii", "jj",
            "aaa", "bbb", "ccc", "ddd", "eee", "fff", "ggg", "hhh", "iii", "jjj"};

    private string[] prefix2 ={"0","1","2","3","4","5","6","7","8","9",
            "00","11","22","33","44","55","66","77","88","99",
            "000","111","222","333","444","555","666","777","888","999"};

    private string[] kindOfItem = {"~","!","@","#","$","%","^","&","*","+",
            "~~","!!","@@","##","$$","%%","^^","&&","**","++",
            "~~~","!!!","@@@","###","$$$","%%%","^^^","&&&","***","+++"};

    public void Start()
    {
        Parent = GameObject.Find("SetOption").GetComponent<Transform>();

        // 아이템을 담을 리스트 생성
        itemBox = new List<GameObject>();
    }

    public void makeNewItem()
    {
        string newPrefix1, newPrefix2, newKindOfItem;

        // 랜덤한 문자열 뽑기
        int r = Random.Range(0, 30);
        newPrefix1 = prefix1[r];
        r = Random.Range(0, 30);
        newPrefix2 = prefix2[r];
        r = Random.Range(0, 30);
        newKindOfItem = kindOfItem[r];

        // 목록에 생성
        newItemObject = Instantiate(originPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        newItemObject.name = newPrefix1 + "  " + newPrefix2 + "  " + newKindOfItem;
        newItemObject.transform.parent = Parent;


        // 생성된 버튼의 텍스트 수정
        itemNameText = newItemObject.transform.Find("ItemName").GetComponent<Text>();
        itemNameText.text = newPrefix1 + "  " + newPrefix2 + "  " + newKindOfItem;

        

        // 리스트에 아이템 저장
        itemBox.Add(newItemObject);
    }


    

}

