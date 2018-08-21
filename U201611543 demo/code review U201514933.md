# code review  
## 一 代码格式
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;这个代码的格式非常好，if else语句之间的格式都十分统一，在if花括号的之后换行编写代码，代码写完之后再次换行用花括号收尾，各个代码语句之间的空格数量都十分统一，整体上看上去很美观。  
## 二 代码可读性
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 代码总体上可读性非常的不错，函数变量的命名都十分准确，并没有为了简便而将变量命名为a,b这一类简短字母的情况出现，而是命名了number1与number2两个变量作为输入的数字，flag作为运算符的变量。函数上也都是统一规范的命名.  
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 同时，函数逻辑结构通顺，简单易懂，可以说编的非常不错，然而在输入数字与符号的编程代码中，编者运用了大量的if else语句，使代码整体变长，略微显得有些啰嗦。    
 ``` private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if(flag==null)
            {
                Number1 += "7";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "7";
                label1.Content = Number2;
            }
        } 
  ```   
   ### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;  所以可以进行一些修改，我个人的初步想法是使用switch case语句，让电脑做出输入是何字符的判断，从而大大检出所需要编程的语句，让代码整体缩短。    
## 三 异常处理   
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 由于编写代码时间较短且接触代码时间不长，程序在异常处理上该代码做的并不够完善，编者想要编写一个计算器，然而当我们试图进行连加功能时程序并没有如预想中直接计算，而是在第一次加出的数字后直接打上了我们第二次想加的数，究其原因，是编者在一开始时已经将变量设定死为number1与number2两个变量，无法做到优先级计算与连加连乘功能。    
```C++
 string Number1 = null, Number2 = null, flag = null;
 ```

## 四 Corner Case  
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 函数中的if…else…全部封闭，也没有忽略非常少见的执行逻辑。
## 五 架构合理性    
### &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 十分合理，常量在开头就设定好，并没有在途中没有规律的塞进去，重复代码段也提取为函数，先进行按钮的编写，再进行计算的编写，整体架构十分出色。