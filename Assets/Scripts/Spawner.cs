using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private Rigidbody2D _enemyRb2D;


    private void Awake()
    {
        _enemyRb2D = _enemy.GetComponent<Rigidbody2D>();
    }

    public void CreatEnemyOnMap()
    {
        _enemy.transform.position = transform.position;

        _enemy.SetActive(true);

        _enemyRb2D.simulated = true;
    }

    public void RemoveEnemyOnMap()
    {
        _enemy.SetActive(false);

        _enemyRb2D.simulated = false;
    }
}
