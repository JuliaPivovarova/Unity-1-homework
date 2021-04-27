using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //[SerializeField]
    //private int _speed; // public видна в инспекторе в unity. Видна отовсюду. Пишутся с большой буквы

    //[SerializeField]
    //private BoxCollider _boxCollider;

    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Transform _spawnPoint;

    private GameObject _instanceCube;
    
    //private int Speed => _speed; // сокращённый вариант get

    //private int _force;

    private void Awake() // получать компоненты извне; включится даже если не сработеат старт. Срабатывает даже при выключенном скрипте
    {
        //Debug.Log("Compelte Awake!!");
    }

    // Start is called before the first frame update
    // Активируется только один раз 
    private void Start()
    {
        //Debug.Log("Compelte start!!"); - вывод в консоль unity

        //_gameSphere.SetActive(false); // скрывает сферу
        //var position = _gameSphere.GetComponent<Transform>().position;
        //Debug.Log(position);
        //var boxCollider = _gameSphere.GetComponent<BoxCollider>();
        //if (boxCollider != null)
        //    Debug.Log(boxCollider.center);

        //gameObject.transform.position = _gameSphere.transform.position; // gameObject - обьект на котором есть этот скрипт 

        _instanceCube = Instantiate(_cube, _spawnPoint.position, Quaternion.identity);

    }

    private void FixedUpdate() // для работы с камерой. Для работы физики. Например столкновения
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Compelte Update!!");
        if (Input.GetMouseButtonDown(0)) // 0 - левая кнопка, 1 - средняя(?), 2 - правая
            Destroy(_instanceCube);

        if (Input.GetKeyDown(KeyCode.W))
        {

        }

        var gameCube = GameObject.Find("Cube");

        Debug.Log(gameCube.transform.position);

    }

    private void LateUpdate() // после окончания каждого кадра. Поворот камеры за действием персонажа (пр-р)
    {
        
    }
} // можно добавить дополнительный класс после
