using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int HP = 30;
    public bool isDied=false;

    public int firstDir = 1;
    public float changeDirTime;

    int moveDir = 1;

    //cat ���� �� �ʿ��� ���� ����

    private void Start()
    {
        StartCoroutine(MoveDirection());
        StartCoroutine(shootBullet());
    }

    private void Update()
    {
        transform.Translate(Vector3.right*moveDir*firstDir*Time.deltaTime);
        if(HP<=0) { 
            isDied = true;
            gameObject.SetActive(false);
        }

    }

    IEnumerator MoveDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeDirTime);
            moveDir *= -1;
        }
    }

    IEnumerator shootBullet()
    {
        //�ڵ� �ۼ� �κ� (�Ʒ� �ڵ� �����ּ���!)
        yield return null;
        
    }
}
