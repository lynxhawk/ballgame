using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeleft;//ʣ��ʱ��
    //�ı���ʾ����ʱ
    public Text CountDown_txt;
    //���ŵ���Ч
    public AudioClip countSound;
    //�Ƿ�ʼ����ʱ
    private bool isCounting;
    // Start is called before the first frame update
    void Start()
    {
        //��ʼ����ʱ
        isCounting = true;

    }

    // Update is called once per frame
    void Update()
    {
        //�ж��Ƿ�ʼ����ʱ
        if (isCounting)
        {
            //����ʱ
            timeleft -= Time.deltaTime;
        }
        //�ı���ʾ����ʱ������
        CountDown_txt.text = "����ʱ��" + timeleft.ToString(format:"0");//ȥ���������С��

        //������ʱС�ڵ���0���ڼ�ʱ״̬��ֹͣ����ʱ�Ͳ�����Ч
        if (timeleft <= 0 && isCounting)
        {
            isCounting = false;
            //������Ч
            //this.GetComponent<AudioSource>().PlayOneShot(countSound);
            SceneManager.LoadScene(2);
        }
    }


}
