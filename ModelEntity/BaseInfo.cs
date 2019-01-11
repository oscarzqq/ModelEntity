using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelEntity
{
    public class BaseInfo
    {

        #region 数据类型转换1
        /// <summary>
        /// 转换字符串（转换失败返回空）
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <returns></returns>
        public static string CVTStr(object obj)
        {
           return CVTStr(obj, "");
        }

        /// <summary>
        /// 转换字符串（转换失败返回制定默认值）
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <param name="defValue">制定返回默认值</param>
        /// <returns></returns>
        public static string CVTStr(object obj,string defValue)
        {
            try
            {
                return obj.ToString().Replace("'","");
            }
            catch
            {

                return defValue;
            }
        }

        /// <summary>
        /// 转换成整型（转换失败返回0）
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <returns></returns>
        public static int CVTInt(object obj)
        {
            return CVTInt(obj, 0);
        }

        /// <summary>
        /// 转换成整型（转换失败返回制定默认值）
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <param name="defValue">制定返回默认值</param>
        /// <returns></returns>
        public static int CVTInt(object obj, int defValue)
        {
            try
            {
                return int.Parse(obj.ToString());
            }
            catch
            {

                return defValue;
            }
        }

        /// <summary>
        /// 转换bool类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool CVTBool(object obj)
        {
            try
            {
                return bool.Parse(obj.ToString());
            }
            catch 
            {

                return false;
            }
        }
        #endregion

        
        /// <summary>
        /// 文本框获取焦点并选中所有
        /// </summary>
        /// <param name="txtBox"></param>
        public static void Focus(TextBox txtBox)
        {
            txtBox.Focus();
            txtBox.Select();
            txtBox.SelectAll();
        }

    }

    #region 系统信息
    public class SystemInfo
    {
        /// <summary>
        /// 用户登录信息
        /// </summary>
        public static string UserID
        {
            get;set;
        }

        /// <summary>
        /// 用户中文名
        /// </summary>
        public static string UserName
        {
            get; set;
        }

        /// <summary>
        /// 系统名称
        /// </summary>
        public static string SystemName
        {
            get; set;
        }
    }

        #endregion

    #region 信息提示框
    /// <summary>
    /// 信息提示框
    /// </summary>
    public class MsgBox
    {
        /// <summary>
        /// 正常信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Information(string msg)
        {
            MessageBox.Show(msg, "系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Warning(string msg)
        {
            MessageBox.Show(msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Error(string msg)
        {
            MessageBox.Show(msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 询问信息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult Question(string msg)
        {
           return MessageBox.Show(msg, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
    #endregion
}
