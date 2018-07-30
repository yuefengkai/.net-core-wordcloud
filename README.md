# .net-core-wordcloud
-----
.net-core爬取豆瓣影评调用Python生成词云
网上一堆**Python**爬取豆瓣xx电影评论生成词云，最近在学习**.net core** 抽空写了一下，原理与**Python**一致.

#### 主要流程如下

> * 爬取指定豆瓣电影->根据Url获取页面Html
使用**HtmlAgilityPack**解析Html获取评论,递归获取下一页，生成文件

> * 使用**结巴分词 JiebaNet** 分析豆瓣评论，将拆分后的数据生成文件

> * 调用**CMD** 启动**Python**使用**WordCloud** 生成词云

-----
![cmd-markdown-logo](https://0.rc.xiniu.com/g2/M00/B9/FF/CgAGfFtfGvaAZoixAAI4gNhROjo608.jpg)
<center>我不是药神</center >

![cmd-markdown-logo](https://0.rc.xiniu.com/g2/M00/BA/00/CgAGfFtfG5qAOeBpAAInZF9PWyc010.jpg)
<center>三体</center >

