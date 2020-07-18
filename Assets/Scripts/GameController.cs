﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Spawn[] _spawn;

    void Start()
    {
        StartCoroutine("SpawnEnemies");
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < _spawn.Length; i++)
            {
                _spawn[i].CreatEnemyOnMap();

                yield return new WaitForSeconds(2);

                _spawn[i].RemoveEnemyOnMap();
            }
        }
    }

}
