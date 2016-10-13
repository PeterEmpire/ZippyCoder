/*-----------------------------------------------------
 * 此类用来扩展 System.Web.UI.HtmlControls.HtmlInputFile，为 HtmlInputFile 增加方法。
 * 
 * 
 * Author：啤酒云 
 * 
 -------------------------------------------------------*/

namespace System.Web.UI.HtmlControls
{
    using System.Drawing;

    public static class HtmlInputFileExtender
    {
        /// <summary>
        /// 验证上传文件，不能为0字节。
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        public static void Validate(this HtmlInputFile fileInput)
        {
            if (string.IsNullOrEmpty(fileInput.PostedFile.FileName))
                throw new Exception("没有文件被上传。");
            if (fileInput.PostedFile.ContentLength == 0)
                throw new Exception("文件长度必须大于0。");
        }

        /// <summary>
        /// 将文件上传，返回一个流。
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <returns></returns>
        public static System.IO.Stream ToStream(this HtmlInputFile fileInput)
        {
            Validate(fileInput);
            return fileInput.PostedFile.InputStream;
        }

        /// <summary>
        /// 上传一个图片文件，如果不是图片文件，则会出错
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <returns></returns>
        public static System.Drawing.Image ToImage(this HtmlInputFile fileInput)
        {
            return System.Drawing.Image.FromStream(fileInput.PostedFile.InputStream);
        }

        /// <summary>
        /// 上传一个图片文件，并保存到指定路径
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <param name="fileName">Name of the file.</param>
        public static void SaveAs(this HtmlInputFile fileInput, string fileName)
        {
            Validate(fileInput);
            fileInput.PostedFile.SaveAs(fileName);
        }

        /// <summary>
        /// Uploads the user icon.
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <param name="virDir">The vir dir.</param>
        /// <param name="userid">The userid.</param>
        /// <param name="scaleLength">Length of the scale.</param>
        /// <param name="sMode">The s mode.</param>
        public static void UploadUserIcon(this HtmlInputFile fileInput, string virDir, object userid, int scaleLength, System.Drawing.ScaleModes sMode)
        {
            string dir = System.Web.HttpContext.Current.Server.MapPath(virDir);
            if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
            string fileName = userid.ToString() + ".jpg";
            string fileSavePath = System.IO.Path.Combine(dir, fileName);

            System.Drawing.Image img = fileInput.ToImage();

            img.Scale(fileSavePath, scaleLength, sMode);
        }

        /// <summary>
        /// Uploads the user icon.
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <param name="virDir">The vir dir.</param>
        /// <param name="userid">The userid.</param>
        /// <param name="scaleLength">Length of the scale.</param>
        public static void UploadUserIcon(this HtmlInputFile fileInput, string virDir, object userid, int scaleLength)
        {
            UploadUserIcon(fileInput, virDir, userid, scaleLength, ScaleModes.Squre);
        }

        /// <summary>
        /// Uploads the user icon.
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <param name="virDir">The vir dir.</param>
        /// <param name="userid">The userid.</param>
        public static void UploadUserIcon(this HtmlInputFile fileInput, string virDir, object userid)
        {
            UploadUserIcon(fileInput, virDir, userid, 75);
        }

        /// <summary>
        /// 上传一个用户头像
        /// </summary>
        /// <param name="fileInput">The file input.</param>
        /// <param name="savingPath">The saving path.</param>
        /// <param name="scaleLength">Length of the scale.</param>
        /// <param name="sMode">The s mode.</param>
        public static void UploadUserIcon(this HtmlInputFile fileInput, string savingPath, int scaleLength, ScaleModes sMode)
        {
            System.Drawing.Image img = fileInput.ToImage();
            img.Scale(savingPath, scaleLength, sMode);

        }


    }
}
