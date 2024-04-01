using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automautogenerate : MonoBehaviour
{
    public GameObject spike; // �����Ԥ����
    public float spawnInterval = 20f; // ���ɼ��ʱ��
    public float spawnRadius = 1f; // ���ɷ�Χ�뾶

    private float spawnTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ÿ֡���¼�ʱ��
        spawnTimer += Time.deltaTime;

        // �����ʱ���ﵽ���ɼ��ʱ��
        if (spawnTimer >= spawnInterval)
        {
            Debug.Log(spawnInterval);
            

            // �������λ��
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            // ���ɷ���
            Instantiate(spike, spawnPosition, Quaternion.identity);
            // ���ü�ʱ��
            spawnTimer = 0f;
        }
       
    }
}
