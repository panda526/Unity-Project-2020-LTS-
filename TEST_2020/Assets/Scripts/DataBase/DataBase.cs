using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 關卡外部資訊
/// </summary>
[System.Serializable]
public struct StageData 
{
	public string name;
	public string stageID;
	public string description;
	public int staminaCost;
	[Header("關卡圖示")]
	public Sprite icon;
	public Sprite symbol;
}
[CreateAssetMenu(fileName = "StageDB", menuName = "DB/StageDB", order = 0)]
public class StageDataBase : ScriptableObject
{
	public List<StageData> stageDatas;
}
[CreateAssetMenu(fileName = "ItemDB", menuName = "DB/ItemDB", order = 1)]
public class ItemDataBase : ScriptableObject
{
	public List<Item> itemList;
    public Item SearchItemByID(string itemID)
    {
        Item item = null;
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].id == itemID)
            {
                item = itemList[i].Clone();
                break;
            }
        }
        return item;
    }
}
/// <summary>
/// 掉落清單
/// </summary>
[System.Serializable]
public struct DropList
{
    public string itemID;
    public float probability;
}
[CreateAssetMenu(fileName = "DropListDB", menuName = "DB/DropListDB", order = 2)]
public class DropListDB : ScriptableObject
{
    [Header("經驗值獲取量")]
    public float exp;
    [Header("金錢獲取量")]
    public int moneyMin;
    public int moneyMax;
    [Range(0, 100)]
    public float dropChance;//掉錢機率
    [Header("掉落物清單")]
    public List<DropList> dropList;
    public int Money()
    {
        int m = 0;
        if (Random.Range(0, 100) < dropChance)
        {
            m = Random.Range(moneyMin, moneyMax);
        }
        return m;
    }
}
