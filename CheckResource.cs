using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public class CheckResource
{
    ///buildin


	public static void CheckEffect ()
    {
		//大小写

        //模型设置

        //贴图设置

        //
	}
	
	public static void CheckModel ()
    {
		//大小写

        //模型设置
        ///关闭导入材质
        ///动画根据@判断是否导入，包括是否循环
        ///

        //贴图设置
        ///压缩大小
        ///

        //材质设置

        //预制体设置
        ///灯光阴影相关是否关闭
        ///

	}

    public static void CheckScene()
    {
        //大小写

        //模型设置

        //贴图设置

        //材质设置，不能使用standard

    }

    public static void CheckUI()
    {
        //大小写

        //模型设置

        //贴图设置

        //材质设置

        //预制体设置

    }

    /// <summary>
    /// 将standard 替换成Mobile Diffuse
    /// </summary>
    private static void ReplaceStandardToDiffuse()
    {
        Shader sd = Shader.Find("Standard");
        Shader diffuse_sd = Shader.Find("Mobile/Diffuse");
        string[] materialsPath = Directory.GetFiles("", "*", SearchOption.AllDirectories);
        foreach (var file in materialsPath)
        {
            Material mt = AssetDatabase.LoadAssetAtPath<Material>(file);
            if (mt && mt.shader == sd)
            {
                Debug.LogErrorFormat("材质使用了Standard Shader：{0}", file);
            }
        }
    }
}
