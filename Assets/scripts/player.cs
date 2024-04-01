using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public int speed = 2;//小球移动速度
    public int Direction;//小球移动方向
    public int minnum = 1;//随机的最小值边界
    public int maxnum = 5;//随机的最大值边界
    public GameObject Text2;
    public float a = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("游戏开始了");
        rd = GetComponent<Rigidbody>();//获取组件
        Direction = Random.Range(minnum, maxnum);
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(new Vector3(10, 0, 0));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h,0,v)*4);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("发生碰撞oncollisionEnter");
    //    if (collision.gameObject.tag == "food")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "food")
        {
            a = a + 0.5f;
            Destroy(other.gameObject);
            score++;
            scoreText.text = "分数："+score+"分";
            rd.GetComponent<Transform>().localScale = new Vector3(a, a, a);
            //rd.transform.localScale
            //Transform transformrd = gameObject.GetComponent<Transform>();
            //transformrd.localScale = new Vector3(a + 0.5f, a + 0.5f, a + 0.5f);
            //transformrd.localScale = new Vector3(a, a, a);
        }
        else if (other.tag == "spike")
        {
            if(a - 2f < 1)
                a = 1;
            else
                a = a - 2f;
            Destroy(other.gameObject);
            score = score - 5;
            scoreText.text = "分数：" + score + "分";
            rd.GetComponent<Transform>().localScale = new Vector3(a, a, a);
            //rd.transform.localScale
            //Transform transformrd = gameObject.GetComponent<Transform>();
            //transformrd.localScale = new Vector3(a - 2f, a - 2f, a - 2f);
            //transformrd.localScale = new Vector3(a, a, a);
        }

    }
    private void Init()
    {
        if (Direction == 1)
        {
            rd.velocity = Vector3.left * speed;
        }
        if (Direction == 2)
        {
            rd.velocity = Vector3.right * speed;
        }
        if (Direction == 3)
        {
            rd.velocity = Vector3.up * speed;
        }
        if (Direction == 4)
        {
            rd.velocity = Vector3.down * speed;
        }
    }

}
