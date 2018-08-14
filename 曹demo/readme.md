#  **暑假Demo简介**
## ***一　项目名称***
###   &nbsp; &nbsp; &nbsp; 在暑假期间我用微信小程序做了一个简易的控制字体大小的程序，主要有三个功能:  
#### 1. &nbsp; &nbsp; 将所编辑的字体放大  
#### 2. &nbsp; &nbsp; 将所编辑的字体缩小  
#### 3. &nbsp; &nbsp; 恢复原来字体的大小    
  

## ***二　代码编写***  
###   &nbsp; &nbsp; &nbsp; 该程序分为多个部分，其中比较重要的是JSON 配置，WXML 模板与JS 交互逻辑。  
#### 1.&nbsp; &nbsp; JSON 配置：  
   &nbsp; &nbsp; &nbsp;JSON 配置是当前小程序的全局配置，包括了小程序的所有页面路径、界面表现、网络超时时间、底部 tab 等，由于我的程序比较简单，只包括了页面路径与界面表现,该段代码主要设计了窗口的背景色，导航栏标题文字内容与颜色代码如下：  
``` c
{
    "pages": [ 
      "index"
    ],
    "window": {
      "navigationBarBackgroundColor": "#000000",
      "navigationBarTextStyle": "white",
      "navigationBarTitleText": "字体改变大小",
      "backgroundColor": "#000000",
      "backgroundTextStyle": "light",
      "enablePullDownRefresh": false
    }
}
```  

#### 2.&nbsp; &nbsp; JS 交互逻辑：  
   &nbsp; &nbsp; &nbsp;在js中实现和用户做交互：响应用户的点击、获取用户的位置等等功能，我这里的事件响应函数中使用了this.setData修改了fontSize为this.data.fontSize+1或this.data.fontSize-1，或让其强制变为原来字体的大小。进而动态修改了index.wxml文件中style="font-size:{{fontSize}}pt"的字体大小，代码如下：   
   ``` c
   Page({
    data:{
        fontSize:15
    },
    large(){
        this.setData({
            fontSize:this.data.fontSize+1
        })
    },
    small(){
        this.setData({
            fontSize:this.data.fontSize-1
        })
    },
   back() {
    this.setData({
      fontSize:15
    })
  }
})
```
#### 3.&nbsp; &nbsp; WXML 模板：  
 &nbsp; &nbsp; &nbsp;在index.wxml文件中进行之前定义的函数的使用，进行网页的编程，用button编写按钮程序，这样就可以在界面上看到自己的字体被放大，缩小了，代码如下：
  ``` c
  <view class="view" style="font-size:{{fontSize}}pt">软件工程训练营</view>
<button class="btn" type="default" bindtap="large">点击字体变大</button>
<button class="btn" type="default" bindtap="small">点击字体变小</button>
<button class="btn" type="default" bindtap="back">点击恢复字体</button>
  ``` 
#### 4.&nbsp; &nbsp;工具配置 project.config.json：  
  &nbsp; &nbsp; &nbsp;恢复到当时自己开发项目时的个性化配置，其中包括编辑器的颜色、代码上传时自动压缩等等一系列选项。
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
	"appid": "wxea47986caba98911",
	"projectname": "4",
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
## ***三　项目测试***  
###  &nbsp; &nbsp; &nbsp;在将程序代码编写完成后，点击微信小程序的预览选项软件将自动生成一个二维码，在限定的时间内用手机对其扫码即可在手机上看到自己的程序效果 ，点击"点击字体放大“就可以放大字体，点击 "点击字体缩小“就可以缩小字体，点击"点击恢复字体“就可以让字体变回原来的大小。

![图片](https://thumbnail0.baidupcs.com/thumbnail/dfb3754fed95887a2562ed949ad434f5?fid=3459579171-250528-670866371249558&time=1534244400&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-WQbJmiPmdf2%2BXk8kau3otIkKuYk%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=5237478720924777713&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video '字体修改大小')

## ***四　思考总结***
###  &nbsp; &nbsp; &nbsp;这是我第一次使用微信小程序编写，做出来的功能可以说比较简陋，有很多地方值得改进，我没有做出可以输入文字再让其放大缩小的功能，当缩小的fontSize减为0后，软件工程训练营将变回原来的大小，而放大则可以一直放大，设计时也应当考虑这一点，不过总的来说这次demo的制作给了我不一样的体验，之前只在课上学习过c++，而微信小程序开发与c语言有着很大的不一样，开拓了我的视野