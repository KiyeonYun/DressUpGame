using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chracter : MonoBehaviour
{
    public Transform hairGroup;
    public Transform upperGroup;
    public Transform bodyGroup;
    public Button btnChangeHair;

    List<GameObject> hairs = new List<GameObject>();
    List<GameObject> uppers = new List<GameObject>();
    List<GameObject> bodies = new List<GameObject>();

    int currentHairNumber = 0;
    int currentUpperNumber = 0;
    int currentBodyNumber = 0;


    void Start()
    {
        MakeDresses(hairGroup, hairs);  // �ݹ�, ����Լ�
        MakeDresses(upperGroup, uppers);
        MakeDresses(bodyGroup, bodies);
        ShowDresses(hairs, 2);
        ShowDresses(uppers, 3);
        ShowDresses(bodies, 4);
    }

    void MakeDresses(Transform group, List<GameObject> dressList)
    {
        foreach (Transform dress in group)
        {
            dress.gameObject.SetActive(false);
            dressList.Add(dress.gameObject);
        }
        dressList[0].SetActive(true);
    }

    void ShowDresses(List<GameObject> group, int dressNumber)
    {
        for (int i = 0; i < group.Count; i++)
        {
            group[i].SetActive(false);
        }
        group[dressNumber].SetActive(true);
    }

    // ��ư�� ������ �Ӹ� ����� ���ϴ� �Լ�
    public void ChangeHair()
    {
        if (currentHairNumber < hairs.Count - 1)
        {
            currentHairNumber++;
        }
        else
        {
            currentHairNumber = 0;
        }
        ShowDresses(hairs, currentHairNumber);
    }

    public void ChangeUpper()
    {
        if (currentUpperNumber < uppers.Count - 1)
        {
            currentUpperNumber++;
        }
        else
        {
            currentUpperNumber = 0;
        }
        ShowDresses(uppers, currentUpperNumber);
    }

    public void ChangeBody()
    {
        if (currentBodyNumber < bodies.Count - 1)
        {
            currentBodyNumber++;
        }
        else
        {
            currentBodyNumber = 0;
        }
        ShowDresses(bodies, currentBodyNumber);
    }

    void Update()
    {

    }
}
