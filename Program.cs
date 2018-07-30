using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace NetCoreWordCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            var commentPath = $"./Files/{DateTime.Now.ToString("yyyyMMddHHmmssff")}.txt";
            if(!new DouBanComment().BuildCommentsFile(commentPath)){
                Console.WriteLine($"获取豆瓣评论失败");
                return;
            }

            if (!File.Exists(commentPath)) {
                Console.WriteLine($"{commentPath}文件未找到");
                return;
            }

            var jiebaFile = new JieBa().Build($"{commentPath}");

            Console.WriteLine("start python...");
            var res = new RunCmd().Run("python/cloud.py",jiebaFile);
            Console.WriteLine(res);
            
            Console.WriteLine("end python...");

            Console.ReadKey();
        }      
    }
}
