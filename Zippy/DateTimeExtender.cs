/*-----------------------------------------------------
 * 此类用来扩展 DateTime，为 DateTime 增加方法。
 * 
 * 
 * 创建者：啤酒云
 * 
 -------------------------------------------------------*/
namespace System
{

    /// <summary>
    /// DateTime 的扩展
    /// </summary>
    public static class DateTimeExtender
    {
        /// <summary>
        /// 返回一个标识消逝时间的字符串
        /// </summary>
        /// <param name="dtTime"></param>
        /// <returns></returns>
        public static string ToPassedAway(this DateTime dtTime)
        {
            DateTime dtNow = DateTime.Now;
            TimeSpan tsDiff = dtNow - dtTime;
            string lastDateStr = dtTime.ToString("yy-MM-dd HH:mm");
            if (tsDiff.TotalMinutes <= 1 && tsDiff.TotalMinutes > 0)
            {
                lastDateStr = "<span style='color:#ff0000' title='" + lastDateStr + "'>" + (int)tsDiff.TotalSeconds + " 秒前</span>";
            }
            else if (tsDiff.TotalHours <= 1)
            {
                lastDateStr = "<span style='color:#cc0000' title='" + lastDateStr + "'>" + (int)tsDiff.TotalMinutes + " 分前</span>";
            }
            else if (tsDiff.TotalHours <= 8)
            {
                lastDateStr = "<span style='color:#990000' title='" + lastDateStr + "'>" + (int)tsDiff.TotalHours + " 小时前</span>";
            }
            else if (tsDiff.Days == 0 && dtNow.Day == dtTime.Day)
            {
                lastDateStr = "<span style='color:#660000' title='" + lastDateStr + "'>今天 " + dtTime.ToString("HH:mm") + "</span>";
            }
            else if (tsDiff.Days <= 1 && dtNow.Day == dtTime.Day + 1)
            {
                lastDateStr = "<span style='color:#330000' title='" + lastDateStr + "'>昨天 " + dtTime.ToString("HH:mm") + "</span>";
            }
            return lastDateStr;// +dtTime + ":::" + tsDiff.Days;
        }
    }
}
