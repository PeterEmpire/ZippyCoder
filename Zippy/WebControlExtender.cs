/*-----------------------------------------------------
 * 此类用来扩展 ASP.NET 服务器端控件。
 * 
 * 
 * 创建者：啤酒云 
 -------------------------------------------------------*/

namespace System.Web.UI.WebControls
{
    using System;
    public static class WebControlExtender
    {
        /// <summary>
        /// 获取比特模式的值，此CheckBoxList选项的赋值必须是 1 2 4 8...
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetBitValue(this CheckBoxList obj)
        {
            int rtn = 0;
            foreach (ListItem li in obj.Items)
            {
                if (li.Selected)
                    rtn |= li.Value.ToInt32();
            }
            return rtn;
        }
        /// <summary>
        /// 设置比特模式的值，此CheckBoxList选项的赋值必须是 1 2 4 8...
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="val"></param>
        public static void SetBitValue(this CheckBoxList obj, int val)
        {
            obj.SelectedIndex = -1;
            foreach (ListItem li in obj.Items)
            {
                li.Selected = val.BitIs(li.Value.ToInt32());
            }
        }

        #region Bind WebControl
        /// <summary>
        /// 绑定控件
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="enumType"></param>
        public static void BindEnum(this ListControl ctrl,Type enumType)
        {
            ctrl.Items.Clear();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string resValue = name;
                ctrl.Items.Add(new System.Web.UI.WebControls.ListItem(resValue, ((int)values.GetValue(i)).ToString()));
            }
        }
        #endregion
    }
}
