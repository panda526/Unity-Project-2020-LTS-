using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseManager : MonoBehaviour
{
	//靜態欄位 表示唯一的自己
	public static DataBaseManager ctrl;
	public StageDataBase stageDB;
	public ItemDataBase ItemDB;
	private void Awake()
	{
		ctrl = this;
		ItemDB = (ItemDataBase)Resources.Load("ItemDB",typeof(ItemDataBase));
		stageDB=(StageDataBase)Resources.Load("StageDB",typeof(StageDataBase));
	}
	// Use this for initialization
	void Start()
	{
		{
			DontDestroyOnLoad(this);
			
		}
	}
}
