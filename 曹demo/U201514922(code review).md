#  **Code Review**
## **1.app.json**

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
### 这一段是设置微信小程序的标题栏，window后的属性写的很清楚。
### 缺点是最后一条属性设置"enablePullDownRefresh": false可以不用写，就算不写也不会有下拉刷新功能。

## **2.index.wxml**
``` c
<view class="view" style="font-size:{{fontSize}}pt">软件工程训练营</view>
<button class="btn" type="default" bindtap="large">点击字体变大</button>
<button class="btn" type="default" bindtap="small">点击字体变小</button>
<button class="btn" type="default" bindtap="back">点击恢复字体</button>
```  
### 这一段是设置小程序界面的程序，可读性非常好，一看就知道是一行显示和三个按钮，按钮分别对应"large"，"small"，"back"三个功能。没毛病。


## **3.index.js**
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
### 这一部分是第二部分的对应，详细写了"large"，"small"，"back"三个功能的代码。
### 三个功能就是在fontSize数据上进行数值的增减。
### 因为标识清楚，可读性也很好。
  
  


## **4.小结**
### 这个微信小程序功能比较简洁，所以程序也一目了然，很好理解。
