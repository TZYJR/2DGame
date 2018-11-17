using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiTuManager : MonoBehaviour {
    [Header("宽")]
    public int kuan;
    [Header("高")]
    public int gao;
    //[SerializeField]
    //[Header("地图的边框")]
    //private List<GameObject> bianJing;
    [SerializeField]
    [Header("背景")]
    private GameObject BJ;
    //边框父物体
    //private Transform bianjing;
    ////背景父物体
    private Transform beijing;
    private void Awake()
    {
        //获取边框父物体
        //bianjing = this.transform.Find("bianjing");
        //获取背景父物体
        beijing = this.transform.Find("BJ");
    }
    /// <summary>
    /// 调用地图初始化
    /// </summary>
    void Start()
    {
        Tu();
    }
    void Tu()
    {
        #region 生成地图背景
        for (int i = 0; i < kuan; i++)
        {
            for (int j = 0; j < gao; j++)
            {
                GameObject obj = Instantiate(BJ, new Vector3(i, j, 0), Quaternion.identity,beijing);
                obj.name = string.Format("{0}_{1}", i, j);
            }
        }
        #endregion
        #region 生成边框
        //for (int i = 0; i < kuan; i++)
        //{
        //    //中上边框
        //    Instantiate(bianJing[4], new Vector3(i, gao + 0.25f, 0), Quaternion.identity, beijing);
        //    //中下边框
        //    Instantiate(bianJing[5], new Vector3(i, -1.25f, 0), Quaternion.identity, beijing);
        //}
        //for (int j = 0; j < gao; j++)
        //{
        //    //中左边框
        //    Instantiate(bianJing[6], new Vector3(-1.25f, j, 0), Quaternion.identity, beijing);
        //    //中右边框
        //    Instantiate(bianJing[7], new Vector3(kuan + 0.25f, j, 0), Quaternion.identity, beijing);
        //}
        ////左上边框
        //Instantiate(bianJing[0], new Vector3(-1.25f, gao + 0.25f, 0), Quaternion.identity, beijing);
        ////左下边框
        //Instantiate(bianJing[1], new Vector3(-1.25f, -1.25f, 0), Quaternion.identity, beijing);
        ////右上边框
        //Instantiate(bianJing[2], new Vector3(kuan + 0.25f, gao + 0.25f, 0), Quaternion.identity, beijing);
        ////右下边框
        //Instantiate(bianJing[3], new Vector3(kuan + 0.25f, -1.25f, 0), Quaternion.identity, beijing);
        #endregion
    }
}
