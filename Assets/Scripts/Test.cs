using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //[SerializeField]
    //private int _speed; // public ����� � ���������� � unity. ����� ��������. ������� � ������� �����

    //[SerializeField]
    //private BoxCollider _boxCollider;

    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Transform _spawnPoint;

    private GameObject _instanceCube;
    
    //private int Speed => _speed; // ����������� ������� get

    //private int _force;

    private void Awake() // �������� ���������� �����; ��������� ���� ���� �� ��������� �����. ����������� ���� ��� ����������� �������
    {
        //Debug.Log("Compelte Awake!!");
    }

    // Start is called before the first frame update
    // ������������ ������ ���� ��� 
    private void Start()
    {
        //Debug.Log("Compelte start!!"); - ����� � ������� unity

        //_gameSphere.SetActive(false); // �������� �����
        //var position = _gameSphere.GetComponent<Transform>().position;
        //Debug.Log(position);
        //var boxCollider = _gameSphere.GetComponent<BoxCollider>();
        //if (boxCollider != null)
        //    Debug.Log(boxCollider.center);

        //gameObject.transform.position = _gameSphere.transform.position; // gameObject - ������ �� ������� ���� ���� ������ 

        _instanceCube = Instantiate(_cube, _spawnPoint.position, Quaternion.identity);

    }

    private void FixedUpdate() // ��� ������ � �������. ��� ������ ������. �������� ������������
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Compelte Update!!");
        if (Input.GetMouseButtonDown(0)) // 0 - ����� ������, 1 - �������(?), 2 - ������
            Destroy(_instanceCube);

        if (Input.GetKeyDown(KeyCode.W))
        {

        }

        var gameCube = GameObject.Find("Cube");

        Debug.Log(gameCube.transform.position);

    }

    private void LateUpdate() // ����� ��������� ������� �����. ������� ������ �� ��������� ��������� (��-�)
    {
        
    }
} // ����� �������� �������������� ����� �����
