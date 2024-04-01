using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automautogenerate : MonoBehaviour
{
    public GameObject spike; // 方块的预制体
    public float spawnInterval = 20f; // 生成间隔时间
    public float spawnRadius = 1f; // 生成范围半径

    private float spawnTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 每帧更新计时器
        spawnTimer += Time.deltaTime;

        // 如果计时器达到生成间隔时间
        if (spawnTimer >= spawnInterval)
        {
            Debug.Log(spawnInterval);
            

            // 随机生成位置
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            // 生成方块
            Instantiate(spike, spawnPosition, Quaternion.identity);
            // 重置计时器
            spawnTimer = 0f;
        }
       
    }
}
