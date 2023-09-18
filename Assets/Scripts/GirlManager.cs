using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlManager : MonoBehaviour
{
    public Transform[] girlLocaters;  // ���� null
    public GameObject girlPrefab;
    List<GameObject> girlList = new List<GameObject>();

    void Start()
    {
        CreateGirlCharacter();
    }

    void CreateGirlCharacter()
    {
        Debug.Log("�迭�� ����: " + girlLocaters.Length);
        for (int i = 0; i < girlLocaters.Length; i++)
        {
            // girlPrefab ������Ʈ�� �����Ͽ� ���
            GameObject girlCharacter = Instantiate(girlPrefab) as GameObject;
            girlCharacter.transform.position = girlLocaters[i].position;
            girlList.Add(girlCharacter);
        }
        print("ĳ������ ���� : " + girlList.Count);
    }

    void Update()
    {
        
    }
}
