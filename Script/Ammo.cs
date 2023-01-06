using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed;
    public float destoytime;//����� ����������� 
    public int damag = 1;//���� 
    public float RadiusRay = 0.1f;//����� ���� 
    public LayerMask ObjectMask;
   

    private void Start()
    {
        Invoke("DestroyAmmo", destoytime);
    }

    

    // Update is called once per frame
    void Update()
    {
        InfoDamag();
    }

    public void InfoDamag()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, RadiusRay, ObjectMask);// ������� ���

        if (hitinfo.collider != null)//���� ��� �������� � ���������
        {
            if (hitinfo.collider.CompareTag("Enemy"))//���� ��� �������� � ��������� � ����� 
            {
                hitinfo.collider.GetComponent<Staticric>().DamagEnumy(damag);// ���������� �����
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);//����������� ���� ������ ���� 

    }
    private void DestroyAmmo()
    {
        Destroy(gameObject);
    }
}
