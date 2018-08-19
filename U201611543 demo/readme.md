# U201611的demo
## 简单计算器程序
### 本文一共分为以下三个部分.  
1.项目主题  
2.测试方法  
3.代码分析

## 1.项目主题  
### 这是一个简单的计算器程序,运行结果如下图所示.    
![图片1](\picture\123.png)
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
![图片2](\picture\456.png) 

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