using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        KongZhi();
    }
    float x;
    float y;
    /// <summary>
    /// 键盘控制
    /// </summary>
    void KongZhi()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            WanJia.Instance.animator.SetBool("Move", true);
            WanJia.Instance.transform.Translate(new Vector3(x * Time.deltaTime, 0, 0));
            WanJia.Instance.transform.Translate(new Vector3(0, y * Time.deltaTime, 0));
        }
        else
        {
            WanJia.Instance.animator.SetBool("Move", false);
        }
        WanJia.Instance.animator.SetFloat("X", x);
        WanJia.Instance.animator.SetFloat("Y", y);
    }
}
