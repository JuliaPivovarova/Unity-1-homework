using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNew : MonoBehaviour
{
    [SerializeField]
    private Transform _transformObject;
    
    [SerializeField]
    private Vector3 _vectorFirst;

    [SerializeField]
    private Vector3 _vectorSecond;

    [SerializeField]
    private float _speed = 1;

    private float _distance;

    private int _a;

    //private void Start()
    //{
    //    _distance = Vector3.Distance(_vectorFirst, transform.position); // transform � ��������� ����� ���������� � ���������������� ��������� ������� �� ������� ���� ������
    //    Debug.Log(_distance);

    //    // position - ������������ ���������� ������� ���������. localPosition - ���������

    //    _distance = (_vectorFirst - transform.position).magnitude;
    //    Debug.Log(_distance);

    //    //Debug.Log(_vectorFirst.magnitude); // ������

    //    var a = _vectorFirst.normalized;
    //    Debug.Log(a);

    //    Debug.Log(Vector3.Dot(_vectorFirst.normalized, _vectorSecond.normalized)); // dot - ��������� ������������
    //    Debug.Log(Vector3.Cross(_vectorFirst.normalized, _vectorSecond.normalized)); // cross - ��������� ������������

        
    //}

    private void Update()
    {
        //transform.position += new Vector3(_speed * Time.deltaTime, 0, 0); // ������. ������ ���� �������� ����� Vector3

        //transform.Translate(Vector3.right * _speed * Time.deltaTime); // ���� ��� �����

        // transform.position = Vector3.MoveTowards(transform.position, _transformObject.position, _speed * Time.deltaTime);

        //transform.position = Vector3.Lerp(transform.position, _transformObject.position, _speed * Time.deltaTime);

        //var relativePosition = _transformObject.position - transform.position;
        //var rotation = Quaternion.LookRotation(relativePosition);
        //transform.rotation = rotation;



        //var angle = Quaternion.Angle(_transformObject.rotation, transform.rotation);
        //Debug.Log(angle);

        //Debug.LogWarning(angle);

        //transform.Rotate(_vectorFirst * _speed * Time.deltaTime);

        //transform.LookAt(_transformObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        var sphere = other.GetComponent<SphereCollider>();

        if (sphere != null)
        {
            other.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var sphere = other.GetComponent<SphereCollider>(); // �� ����������� ���������� ��� �������

        if (other.gameObject.CompareTag("Enemy"))
        {
            _a = 5;
        }

        if (sphere != null)
        {
            other.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�����. Stay!!");
    }
}
