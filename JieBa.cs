using System.IO;
using JiebaNet.Segmenter;
class JieBa {

    /// <summary>
    /// 生成分词文件
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public string Build (string path) {

        var html = System.IO.File.ReadAllText (path, System.Text.Encoding.UTF8);

        var segmenter = new JiebaSegmenter ();

        segmenter.LoadUserDict ("Files/dict.txt");

        var segments = segmenter.Cut (html, cutAll : true); //全匹配

        var jiebaFIle = $"{path}.jieba";

        System.IO.File.WriteAllText (jiebaFIle, string.Join (" ", segments), System.Text.Encoding.UTF8); //生成分词文件

        return jiebaFIle;
    }
}