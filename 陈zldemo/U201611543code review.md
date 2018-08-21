# code review  
注:本组其他4人中,有三个做了微信小程序,还有一个未提交源码无法进行code review.而我对于微信小程序也不了解,所以本篇code review也是边学边做的,可能做的也不是很好:)  
## 1.js文件  
&nbsp;&nbsp;&nbsp;&nbsp;js文件用于表示页面逻辑.
## 2.wxml文件
&nbsp;&nbsp;&nbsp;&nbsp;wxml文件用于表示页面结构.
``` c
<view class='container'> 
 <image class='about-banner'src="/images/IMG_3769.JPG"></image>
 <text class="info">博物小百科</text>
 <view>
 <navigator style='display:inline;' url='/pages/weekly/weekly'open-type="redirect" hover-class='nav-hover'>每周更新</navigator>
 <text>博物小知识</text>
 </view>
 <text>我的微博：weibo.com/simbasong</text>
 </view>

```
&nbsp;&nbsp;&nbsp;&nbsp;使每日更新成为了跳转按钮.
## 3.wxss文件
&nbsp;&nbsp;&nbsp;&nbsp;wxml文件用于表示页面样式表.
``` c
.container{
  background-color:#eee;
  height:100vh;
  display:flex;
  flex-direction:column;
  justify-content:space-around;
  align-items:center;
}
```
&nbsp;&nbsp;&nbsp;&nbsp;配置了页面的排版大小和颜色
## 4.json文件
&nbsp;&nbsp;&nbsp;&nbsp;json文件用于表示页面配置.
``` c
{
  "navigationBarBackgroundColor": "#ffffff",
  "navigationBarTextStyle": "black",
  "navigationBarTitleText": "关于"
  
}
```
&nbsp;&nbsp;&nbsp;&nbsp;navigationBar表示对于导航栏的配置.  
&nbsp;&nbsp;&nbsp;&nbsp;首先是navigationBarBackgroundColor背景颜色,要通过16进制数来表示,#ffffff表示的是白色.  
&nbsp;&nbsp;&nbsp;&nbsp;然后是navigationBarTextStyle表示字体颜色,设置为黑色.
&nbsp;&nbsp;&nbsp;&nbsp;最后是navigationBarTitleText表示字体内容,设置为关于.
```
{
  "pages":["pages/about/about","pages/weekly/weekly"]
}
```  
&nbsp;&nbsp;&nbsp;&nbsp;总体配置的json文件,pages字段是用于描述当前小程序所有页面路径.
## 5.project文件
&nbsp;&nbsp;&nbsp;&nbsp;这是一个工具配置文件,在工具上的配置都会写入这个文件,即使更换电脑,也能继续使用你的个性化配置.


  
  ## 总结:这个微信小程序功能大致就是点击更新按钮就可以跳转页面,功能比较简单,实现也比较容易,没有什么错误或者是重复冗杂的代码.还是稍微有点缺少注释,有些语句的功能可以大致用注释说明一下可能会更好一些.