using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersBundle : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawner;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < _spawner.Length; i++)
            {
                _spawner[i].CreatEnemyOnMap();

                yield return new WaitForSeconds(2);

                _spawner[i].RemoveEnemyOnMap();
            }
        }
    }

}
