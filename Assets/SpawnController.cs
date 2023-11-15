using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    [SerializeField]
    GameObject AinaPrefab;

    [SerializeField]
    GameObject Spawner;

    [SerializeField]
    float CooldownBetween = 0.5f;
    float CooldownLast = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CooldownLast += Time.deltaTime;

        if (CooldownLast > CooldownBetween)
        {
            Instantiate(AinaPrefab);
            CooldownLast = 0;
        }
    }
}