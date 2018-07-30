# -*- coding: utf-8 -*-
from wordcloud import WordCloud
import os
import io
import sys
import PIL
from PIL import Image
import numpy as np
from wordcloud import WordCloud,ImageColorGenerator
import matplotlib.pyplot as plt
import random
from random import choice

jiebaFile = str(sys.argv[1]) #读取参数

with io.open(jiebaFile, "r", encoding='utf-8') as f:
    comment = f.read()  # 一次性读全部成一个字符串

path = './fonts/hwxw.ttf'
#path = './fonts/CabinSketch-Bold.ttf'

number = str(random.uniform(1, 9999))

templates=os.listdir("./Template/")

alien_mask = np.array(PIL.Image.open('./Template/'+ choice(templates)))

wc = WordCloud(font_path=path, background_color='white', margin=5, width=800, height=800,mask=alien_mask, max_words=2000, max_font_size=60, random_state=42)
wc = wc.generate(comment)

image_colors = ImageColorGenerator(alien_mask)

plt.figure()
# 重新着色，使用背景图片中的颜色
plt.imshow(wc.recolor(color_func=image_colors))
plt.axis("off")
# 绘制背景图片为颜色的图片

# 保存图片
wc.to_file('./OutFiles/out-image-'+number+'.jpg')

plt.close()
print './OutFiles/out-image-out'+number+'.jpg'
