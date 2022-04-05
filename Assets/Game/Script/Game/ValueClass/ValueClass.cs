using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//专门为大数字而准备的数值类
public class ValueClass
{
    //符号 数字加符号显示
    public string valueStr { get; set; }

    //数值
    public virtual double valueNum { get; set; }

    public virtual double valueMax => double.MaxValue;

    //数值显示
    public enum Type : int
    {
        //科学
        N=1,
        //符号
        S=2,
    }
    
}

