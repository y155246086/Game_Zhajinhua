//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1022
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections.Generic;
using BattleFramework.Data;
using UnityEngine.UI;
using Mogo.Util;
public class GameCommonUtils
{
	public GameCommonUtils ()
	{
	}
	private static GameCommonUtils instance;

	public static GameCommonUtils Instance{
		get{
			if(instance == null){
				instance = new GameCommonUtils();
			}
			return instance;
		}
	}
	public string FormatNumber(int source)
	{
		string target = source > 999999 ? ((int)(source / 10000)) + "万" : source.ToString();
		return target;
	}

	
    public String LastTimeFormat(int second)
    {
        int day = second / (24 * 3600);
        int hour = (second % (24 * 3600)) / 3600;
        int minute = (second % 3600) / 60;
        int leftSecond = second % 60;
        string temp = "";
        if(day > 0 ){
            temp = day + "天" + hour + "时";
        }else if(hour > 0){
            temp = hour + "时" + minute + "分";
        }else if (minute > 0)
        {
            temp = minute + "分" + leftSecond + "秒";
        }
        else if (leftSecond > 0)
        {
            temp  = leftSecond + "秒";
        }
        return temp;
    }
    public String TimeFormat_HH_MM_SS(int second,string format = "hh:mm:ss")
    {
        int day = second / (24 * 3600);
        int hour = (second % (24 * 3600)) / 3600;
        int minute = (second % 3600) / 60;
        int leftSecond = second % 60;

         if(hour > 9)
         {
             format = format.Replace("hh", hour.ToString());
         }
         else if(hour > 0)
         {
             format = format.Replace("hh", "0" + hour.ToString());
         }
         else
         {
             format = format.Replace("hh", "00");
         }

         if (minute > 9)
         {
             format = format.Replace("mm", minute.ToString());
         }
         else if (minute > 0)
         {
             format = format.Replace("mm", "0" + minute.ToString());
         }
         else
         {
             format = format.Replace("mm", "00");
         }

         if (leftSecond > 9)
         {
             format = format.Replace("ss", leftSecond.ToString());
         }
         else if (leftSecond > 0)
         {
             format = format.Replace("ss", "0" + leftSecond.ToString());
         }
         else
         {
             format = format.Replace("ss", "00");
         }
         return format;
    }
   

    static public void Destroy(UnityEngine.Object obj)
    {
        if (obj)
        {
            if (obj is Transform)
            {
                Transform t = (obj as Transform);
                GameObject go = t.gameObject;

                if (Application.isPlaying)
                {
                    t.SetParent(null);
                    UnityEngine.Object.Destroy(go);
                }
                else UnityEngine.Object.DestroyImmediate(go);
            }
            else if (obj is GameObject)
            {
                GameObject go = obj as GameObject;
                Transform t = go.transform;

                if (Application.isPlaying)
                {
                    t.parent = null;
                    UnityEngine.Object.Destroy(go);
                }
                else UnityEngine.Object.DestroyImmediate(go);
            }
            else if (Application.isPlaying) UnityEngine.Object.Destroy(obj);
            else UnityEngine.Object.DestroyImmediate(obj);
        }
    }

    public Color Convet16StringToColor(string str)
    {
        int intValue = Convert.ToInt32(str, 16);
        byte b = (byte)(intValue % 256);
        byte g = (byte)((intValue / 256) % 256);
        byte r = (byte)(intValue / (256 * 256));
        return new Color32(r,g,b,255);
    }
    
    /// <summary>
    /// 获取粒子特效播放时间
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public float GetParticleSystemPlayTime(Transform t)
    {
        ParticleSystem[] particleSystems = t.GetComponentsInChildren<ParticleSystem>();
        float maxDuration = 0;
        foreach (ParticleSystem ps in particleSystems)
        {
            if (ps.enableEmission)
            {
                if (ps.loop)
                {
                    return -1f;
                }
                float dunration = 0f;
                if (ps.emissionRate <= 0)
                {
                    dunration = ps.startDelay + ps.startLifetime;
                }
                else
                {
                    dunration = ps.startDelay + Mathf.Max(ps.duration, ps.startLifetime);
                }
                if (dunration > maxDuration)
                {
                    maxDuration = dunration;
                }
            }
        }
        return maxDuration;
    }


    /// <summary>
    /// 将阿拉伯数字转换成汉字
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string SwitchNumToHanZi(int num)
    {
        if (num > 9)
        {
            return "";
        }
        string result = "";
        switch (num)
        {
            case 1:
                result = "一";
                break;
            case 2:
                result = "二";
                break;
            case 3:
                result = "三";
                break;
            case 4:
                result = "四";
                break;
            case 5:
                result = "五";
                break;
            case 6:
                result = "六";
                break;
            case 7:
                result = "七";
                break;
            case 8:
                result = "八";
                break;
            case 9:
                result = "九";
                break;
        }
        return result;
    }

    /// <summary>
    /// 将时间戳转化为TimeData;
    /// </summary>
    /// <param name="timeStamp"></param>
    /// <returns></returns>
    public DateTime StampToDataTime(long timeStamp)
    {
        DateTime startDataTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        long time = timeStamp * 10000000;
        TimeSpan toStamp = new TimeSpan(time);
        return startDataTime.Add(toStamp);
    }


    /// <summary>
    ///  将TimeData转换为时间戳
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    public long DataTimeToStamp(DateTime time)
    {
        DateTime startDataTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        return (long)((time - startDataTime).TotalSeconds);
    }
}




