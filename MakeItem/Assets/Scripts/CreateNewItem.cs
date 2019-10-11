using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewItem : MonoBehaviour
{

    public void OnButtonClicked()
    {


        GameObject.Find("ItemListView").GetComponent<myItems>().makeNewItem();
    }
}
