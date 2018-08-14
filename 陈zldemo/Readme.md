#  **陈致利的Demo**
## ***1.项目名称***
### 博物小百科
  

## ***2.功能介绍***  
### 一个微信小程序，每周向用户推送一个博物的百科知识。
### 总共有两个页面，第一个是小程序的总页面，第二个是本周推送的小百科内容页面。
### 点击第一个页面上的“每周更新”，字体会变成红色，进入第二个页面，并且不能返回。


## ***3.项目测试*** 

![图片](https://thumbnail0.baidupcs.com/thumbnail/d429e2fdfb49b429930475057ba407d3?fid=3459579171-250528-209716702503674&time=1534262400&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-QEm5sR3M3nwIPwwSDMLa0olInWM%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=5241715574624609766&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video)
### 点击“每周更新”跳转
![图片](https://thumbnail0.baidupcs.com/thumbnail/d5efc5ff376ce88b863a2d24e48ea7db?fid=3459579171-250528-529398719737505&time=1534262400&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-WSQ49BZvicjx4ggo8jn47KI1Ork%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=5241703408522489546&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video)
### 就可以看到本周的小百科内容啦
## ***4.部分代码***
#### 写出部分重要代码，重复内容省略
### (1)页面设置
### Json文件
``` c
{
  "navigationBarBackgroundColor": "#ffffff",
  "navigationBarTextStyle": "black",
  "navigationBarTitleText": "关于"
  
}
```
### Wxml文件
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
### 其中 “<navigator style='display:inline;' url='/pages/weekly/weekly'open-type="redirect" hover-class='nav-hover'>每周更新</navigator>”使“每日更新成为跳转按钮   
### Wxml文件
``` c

.info{
  font-weight:bold;font-size:60rpx;
  }
.about-banner{
  width:375rpx;
  height:375rpx;

}
.nav-hover{
  color:red;
}

```
### （2）总体设置
### Json文件
``` c
{
  "pages":["pages/about/about","pages/weekly/weekly"]
}


```
### wxss文件
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
### project文件
``` c
{
	"description": "项目配置文件。",
	"packOptions": {
		"ignore": []
	},
	"setting": {
		"urlCheck": true,
		"es6": true,
		"postcss": true,
		"minified": true,
		"newFeature": true
	},
	"compileType": "miniprogram",
	"libVersion": "2.2.2",
	"appid": "wxf3b5d7ee0aea168f",
	"projectname": "%E5%B0%8F%E7%A8%8B%E5%BA%8F2",
	"isGameTourist": false,
	"condition": {
		"search": {
			"current": -1,
			"list": []
		},
		"conversation": {
			"current": -1,
			"list": []
		},
		"game": {
			"currentL": -1,
			"list": []
		},
		"miniprogram": {
			"current": -1,
			"list": []
		}
	}
}

```






## ***4.思考总结***
### 这是我按照老师给的教程，跟着教程的步骤做的简单的微信小程序。因为时间关系功能还没有完成，目前只有页面的排布和页面之间的跳转部分的内容。通过这个对微信小程序的编写有了初步的熟悉。