using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/*切换场景必须添加的前缀*/
 
public class StartGame : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }

    public void startgame()/*定义一个切换场景*/
    {
        SceneManager.LoadScene(1);/*双引号里面填入你创建的场景命名*/
    }

     public void myExit()
    {
        Application.Quit();
    }

}