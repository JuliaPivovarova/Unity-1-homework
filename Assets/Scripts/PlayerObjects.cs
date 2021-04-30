using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjects : MonoBehaviour
{
    private GameObject _object;

    [SerializeField]
    private GameObject _door1;

    [SerializeField]
    private GameObject _door2_open;
    [SerializeField]
    private GameObject _door2;
    [SerializeField]
    private GameObject _door3;

    [SerializeField]
    private GameObject _key1;

    [SerializeField]
    private GameObject _key2;
    [SerializeField]
    private GameObject _key3;

    [SerializeField]
    private GameObject _bomb1;

    [SerializeField]
    private GameObject _bomb2;

    [SerializeField]
    private GameObject _bomb3;
    [SerializeField]
    private GameObject _gargoyl1;
    [SerializeField]
    private GameObject _gargoyl2;
    [SerializeField]
    private GameObject _gargoyl3;
    [SerializeField]
    private GameObject _gargoyl4;
    [SerializeField]
    private GameObject _gargoyl5;
    [SerializeField]
    private GameObject _gargoyl6;



    //private int _numberOfSpiritKeys = 0;
    private int _numberOfSpiritBombs = 0;

    private bool m_IsKeyInRange = false;
    private bool m_IsBombInRange = false;
    private bool _isKey1InHand = false;
    private bool _isKey2InHand = false;
    private bool _isKey3InHand = false;
    private bool _IsDoor1InRange = false;
    private bool _IsDoor2InRange = false;
    private bool _IsDoor3InRange = false;
    private bool _IsGargoylInRange = false;

    private Collider key1Coll;
    private Collider key2Coll;
    private Collider key3Coll;
    private Collider bomb1Coll;
    private Collider bomb2Coll;
    private Collider bomb3Coll;


    private void Start()
    {
        key1Coll = _key1.GetComponent<Collider>();
        key2Coll = _key2.GetComponent<Collider>();
        key3Coll = _key3.GetComponent<Collider>();
        bomb1Coll = _bomb1.GetComponent<Collider>();
        bomb2Coll = _bomb2.GetComponent<Collider>();
        bomb3Coll = _bomb3.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == key1Coll|| other == key2Coll || other == key3Coll)
        {
            if (other == key1Coll)
            {
                _object = _key1;
                //_isKey1InHand = true;
            }
                
            if (other == key2Coll)
            {
                _object = _key2;
                //_isKey2InHand = true;
            }
                
            if (other == key3Coll)
            {
                _object = _key3;
                //_isKey3InHand = true;
            }
                
            m_IsKeyInRange = true;
        }

        if (other == bomb1Coll || other == bomb2Coll || other == bomb3Coll)  
        {
            if (other == bomb1Coll)
                _object = _bomb1;
            if (other == bomb2Coll)
                _object = _bomb2;
            if (other == bomb3Coll)
                _object = _bomb3;
            m_IsBombInRange = true;
        }

        if (other == _door1.GetComponent<Collider>())
        {
            _IsDoor1InRange = true;
            _object = _door1;
        }

        if (other == _door2_open.GetComponent<Collider>())
        {
            _IsDoor2InRange = true;
            _object = _door2;
        }
        if (other == _door3.GetComponent<Collider>())
        {
            _IsDoor3InRange = true;
            _object = _door3;
        }

        if (_gargoyl1 != null && other == _gargoyl1.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl1;
        }
        if (_gargoyl2 != null && other == _gargoyl2.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl2;
        }
        if (_gargoyl3 != null && other == _gargoyl3.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl3;
        }
        if (_gargoyl4 != null && other == _gargoyl4.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl4;
        }
        if (_gargoyl5 != null && other == _gargoyl5.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl5;
        }
        if (_gargoyl6 != null && other == _gargoyl6.GetComponent<Collider>())
        {
            _IsGargoylInRange = true;
            _object = _gargoyl6;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == key1Coll || other == key2Coll)
        {
            m_IsKeyInRange = false;
        }

        if (other == bomb1Coll || other == bomb2Coll || other == bomb3Coll)
        {
            m_IsBombInRange = false;
        }

        if (other == _door1.GetComponent<Collider>())
        {
            _IsDoor1InRange = false;
        }

        if (other == _door2.GetComponent<Collider>())
        {
            _IsDoor2InRange = false;
        }

        if (other == _door3.GetComponent<Collider>())
        {
            _IsDoor3InRange = false;
        }
        if (_gargoyl1 != null && other == _gargoyl1.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
        if (_gargoyl2 != null && other == _gargoyl2.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
        if (_gargoyl3 != null && other == _gargoyl3.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
        if (_gargoyl4 != null && other == _gargoyl4.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
        if (_gargoyl5 != null && other == _gargoyl5.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
        if (_gargoyl6 != null && other == _gargoyl6.GetComponent<Collider>())
        {
            _IsGargoylInRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsKeyInRange)
        {
            if (Input.GetKeyDown(KeyCode.E) && _object.activeInHierarchy)
            {
                if (_object == _key1)
                    _isKey1InHand = true;
                if (_object == _key2)
                    _isKey2InHand = true;
                if (_object == _key3)
                    _isKey3InHand = true;
                _object.SetActive(false);
            }
        }
        if (m_IsBombInRange)
        {
            if (Input.GetKeyDown(KeyCode.E) && _object.activeInHierarchy)
            {
                _numberOfSpiritBombs++;
                _object.SetActive(false);
                //m_IsBombInRange = false;
            }
        }
        if (_IsDoor1InRange)
        {
            if (_isKey1InHand && Input.GetKeyDown(KeyCode.E))
            {
                _door1.SetActive(false);
            }
        }
        if (_IsDoor2InRange)
        {
            if (_isKey2InHand && Input.GetKeyDown(KeyCode.E))
            {
                _door2.SetActive(false);
            }
        }
        if (_IsDoor3InRange)
        {
            if (_isKey3InHand && Input.GetKeyDown(KeyCode.E))
            {
                _door3.SetActive(false);
            }
        }
        if (_IsGargoylInRange)
        {
            if (_numberOfSpiritBombs > 0 && Input.GetKeyDown(KeyCode.F))
            {
                Destroy(_object);
                _numberOfSpiritBombs--;
                //_IsGargoylInRange = false;
            }
        }
    }
}
