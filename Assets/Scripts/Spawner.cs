using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            var cube = Instantiate(_cube);
            cube.transform.position = new Vector3(Random.Range(10, -10), 20, Random.Range(10, -10));
        }
    }
}
