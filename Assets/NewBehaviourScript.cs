using System.Collections;
using System.Collections.Generic;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

// 定义一个类型继承MoAttribute
public class TestAttribute : MoAttribute
{
    public override void OnEntry(MethodContext context)
    {
        // OnEntry对应方法执行前
        Debug.LogError("OnEntry");
    }

    public override void OnException(MethodContext context)
    {
        // OnException对应方法抛出异常后
        Debug.LogError("OnException");
    }

    public override void OnSuccess(MethodContext context)
    {
        // OnSuccess对应方法执行成功后
        Debug.LogError("OnSuccess");
    }

    public override void OnExit(MethodContext context)
    {
        // OnExit对应方法退出时
        Debug.LogError("OnExit");
    }
}

public class NewBehaviourScript : MonoBehaviour
{
    [Test]
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}