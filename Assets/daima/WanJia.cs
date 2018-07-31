using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanJia : MonoBehaviour {
    public static WanJia Instance;
    [HideInInspector]
    public Animator animator;
    private void Awake()
    {
        Instance = this;
        animator = this.GetComponent<Animator>();
    }
}
