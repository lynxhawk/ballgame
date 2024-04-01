using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeleft;//剩余时间
    //文本显示倒计时
    public Text CountDown_txt;
    //播放的音效
    public AudioClip countSound;
    //是否开始倒计时
    private bool isCounting;
    // Start is called before the first frame update
    void Start()
    {
        //开始倒计时
        isCounting = true;

    }

    // Update is called once per frame
    void Update()
    {
        //判断是否开始倒计时
        if (isCounting)
        {
            //倒计时
            timeleft -= Time.deltaTime;
        }
        //文本显示倒计时的数字
        CountDown_txt.text = "倒计时：" + timeleft.ToString(format:"0");//去除掉后面的小数

        //到倒计时小于等于0和在计时状态，停止倒计时和播放音效
        if (timeleft <= 0 && isCounting)
        {
            isCounting = false;
            //播放音效
            //this.GetComponent<AudioSource>().PlayOneShot(countSound);
            SceneManager.LoadScene(2);
        }
    }


}
