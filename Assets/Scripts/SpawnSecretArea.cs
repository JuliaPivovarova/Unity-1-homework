using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSecretArea : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    [SerializeField]
    private GameObject _spawnGhost1;

    [SerializeField]
    private Transform _spawnPoint1;

    [SerializeField]
    private GameObject _spawnGhost2;

    [SerializeField]
    private Transform _spawnPoint2;

    private bool m_IsPlayerEnter = false;
    private GameObject _spawnGhost;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            m_IsPlayerEnter = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsPlayerEnter)
        {
            _spawnGhost1.SetActive(true);
            _spawnGhost = Instantiate(_spawnGhost1, _spawnPoint1.position, Quaternion.identity);
            _spawnGhost2.SetActive(true);
            _spawnGhost = Instantiate(_spawnGhost2, _spawnPoint2.position, Quaternion.identity);
            gameObject.SetActive(false);
            
        }
    }
}
