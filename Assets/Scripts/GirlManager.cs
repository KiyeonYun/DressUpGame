using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlManager : MonoBehaviour
{
    public Transform[] girlLocaters;  // 선언 null
    public GameObject girlPrefab;
    List<GameObject> girlList = new List<GameObject>();

    void Start()
    {
        CreateGirlCharacter();
    }

    void CreateGirlCharacter()
    {
        Debug.Log("배열의 개수: " + girlLocaters.Length);
        for (int i = 0; i < girlLocaters.Length; i++)
        {
            // girlPrefab 오브젝트를 복제하여 사용
            GameObject girlCharacter = Instantiate(girlPrefab) as GameObject;
            girlCharacter.transform.position = girlLocaters[i].position;
            girlList.Add(girlCharacter);
        }
        print("캐릭터의 개수 : " + girlList.Count);
    }

    void Update()
    {
        
    }
}
