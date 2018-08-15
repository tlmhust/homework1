# 作业1
## 1.谭力铭的demo
## 简单计算器程序
### 本文一共分为以下三个部分.  
1.功能介绍  
2.测试方法  
3.代码分析  

## 1.功能介绍  
### 这是一个简单的计算器程序,运行结果如下图所示.    
![图片](https://thumbnail0.baidupcs.com/thumbnail/5d53be8e6333e4340ea4ccbb0a80e822?fid=2550669515-250528-656758070177456&time=1534244400&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-uX7AHkaUHFiB4n6mGOoY%2FnJVQ1U%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=8695700270090074587&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video)  
### 该计算器有以下两个功能
(1)能够进行数字运算  
(2)都够保存历史纪录

## 2.测试方法
### 用VS2017打开WpfApp4.sln文件然后开始测试.   
(1)数字运算测试  
通过已知的数学计算进行验证,如:1+1=2,6*6=36.  
(2)保存历史纪录测试
进行一定的计算后,点击左上角的编辑-保存历史纪录,则可以在以下目录中找到一个文本文件TanLimingdemo\WpfApp4\WpfApp4\bin\Debug\result.txt  
则可以在那个txt文件中找到如图所示结果  
![图片](https://thumbnail0.baidupcs.com/thumbnail/bd592a1fa0e61683d27f587040ab9275?fid=2550669515-250528-333227522449279&time=1534244400&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-JpAu%2B1mLYYFIjnIDeaRNEiTX1oA%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=8696017099849410150&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video)  

该图片记录了之前几次运算的历史纪录.
## 3.代码分析
### (1)变量的定义
```c#
string Number1 = null, Number2 = null, flag = null;
        List<string> expressions = new List<string>();
```
该代码定义了所需要的变量,Number1为运算符前的数字,Number2为运算符后的数字,flag为运算符,定义一个expressions表是为了做文件输出的作用,记录算式.
### (2)按键1的操作
```c#
private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "1";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "1";
                label1.Content = Number2;
            }
        }

```
该代码表示在按键1之后的操作,当操作符为空时,输入的是第一个数字,但操作符存在时,输入的是第二个数字,通过+号表示字符串的连接.
### (3)按键+的操作
```c#
 private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            flag = "+";
            
        }
```
该代码表示在按键+之后的操作,令操作符flag为+,与后面的=号操作进行配合.
### (4)按键=的操作

```c#
private void Button_equ_Click(object sender, RoutedEventArgs e)
        {
            switch(flag)
            {
                case "+":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "+" + Number2 + "=" + label1.Content);
                    break;
                case "-":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "-" + Number2 + "=" + label1.Content);
                    break;
                case "*":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "*" + Number2 + "=" + label1.Content);
                    break;
                case "/":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "/" + Number2 + "=" + label1.Content);
                    break;
            }
            Number1 = null;
            Number2 = null;
            flag = null;
        }
```
该代码表示的是按=号之后的操作,当flag为+号时,先将Number1和Number2转换成double型相加然后再转换成字符串型像是在label1的content上.之后再将Number1和Number2和flag变为空从而准备下一次的运算.  
### (5)按键Del的操作
``` c#
private void Button_del_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                if (Number1 != null)
                {
                    if (Number1.Length > 0)
                        Number1 = Number1.Remove(Number1.Length - 1);
                    label1.Content = Number1;
                }
            }
            else
            {
                if (Number2 != null)
                {
                    if (Number2.Length > 0)
                        Number2 = Number2.Remove(Number2.Length - 1);
                    label1.Content = Number2;
                }
            }
        }
```
该代码表示的是按del键之后的操作,先通过判断flag是否为空来觉得删除的是Number1还是2.Number.Length是判断Number中字符个数,当字符大于0个时才能进行删除操作.而因为Length只能用于Number不为空时,所以在前面添加了一个是否为空的判断.
### (6)按键C的操作
```c#
private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Number1 = null;
            Number2 = null;
            flag = null;
            label1.Content = "0";
        }
```
将所有变量都变为NULL即清空,同时显示0.
### (7)历史纪录操作
```c#
private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileStream resultfile = new FileStream("result.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(resultfile);
            foreach (string a in expressions)
            {
                streamWriter.WriteLine(a);
            }
            streamWriter.Close();
        }  
```
该操作是将expression中的每个字符遍历输出,通过文件操作进行,就可以输出之前的历史运算.   
## 2.曹善康的demo
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
## 3.陈致利的demo
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
## 4.李家成的demo
## 5.相雨的demo
1.  star：五星评分
2. ![二维码](\images\1.jpg "二维码")


3. 点击即可改变星星亮起的数量
