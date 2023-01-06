using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class Gun : MonoBehaviour
{
    public float offset = 180f;
    public GameObject bullet;
    public Transform shotpoint;


    private UnityEngine.Object _particleShot;


    private AudioSource _audioSource;



    private float shot;
    public float start;//время между выстрелами

    public int Ammo = 50; //колличество пуль
    [SerializeField] private Text _ammo;

    void Start()
    {
        _particleShot = Resources.Load("ParticleShot");
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _ammo.text = Ammo.ToString();
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);


       



        //полет пули
        if (shot <= 0 && Ammo > 0)
        {
            
            if (Input.GetMouseButton(0))
            {
                GameObject _particleShotPef = (GameObject)Instantiate(_particleShot);
                _particleShotPef.transform.position= new Vector3(shotpoint.transform.position.x, shotpoint.transform.position.y, shotpoint.transform.position.z);
                 
                _audioSource.Play();

                Ammo--;

                Instantiate(bullet, shotpoint.position, transform.rotation);
                shot = start;

            }
        }
        else
        {
            shot -= Time.deltaTime;
        }
    }

   
}
