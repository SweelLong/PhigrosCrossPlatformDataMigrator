# 《软件PhigrosCrossPlatformDataMigrator介绍》
### 欢迎使用Phigros跨系统存档迁移器 - 由SweelLong开发
##### 功能是将安卓系统的存档数据文件（*.xml）转移至苹果系统的数据文件（*.plist）
##### 所以可以认为这是xml转plist的简单工具
##### 目前仅支持将安卓存档转移为苹果存档
##### 旨在解决苹果端不能使用云存档功能

##### 源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
##### 新文件：games.Pigeon.Phigros.plist

### [点击立即前往下载](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/releases/tag/1.0.0.0)
---

# 《Phigros-解决苹果端无法云同步问题》

### 本人最近换设备后突然想要继续游玩屁股肉
### 发现苹果端无法同步之前的数据就多方查询
### 结合多种资料整合出这种方案以跨系统同步
### 目前还不打算使用安卓设备故没有逆向转移
### 如果有逆向转移存档的需求则可以联系本人
### 由于安卓端同步功能是正常的所以有此教程
### 目标是将安卓端的存档数据文件转至苹果端
### 源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
### 新文件：games.Pigeon.Phigros.plist

## 第一步获取安卓端存档：
##### 提取的方法有很多哈，需要Root（直接操作）和无需Root（连接电脑）的都有
##### 网络上有一种[安卓手机无需root的方法](https://docs.qq.com/doc/DZm9FSUZSRUZBekhB)
##### 我这里提供电脑直接获取的方法——模拟器，前提是需要开启虚拟化
##### 本教程使用[雷电模拟器9](https://www.ldmnq.com)做演示：
### 1.安装模拟器，这里就不做过多解释了，直接跳过
### 2.安装Phigros，如果有Phigros.apk就直接安装，此教程使用[TapTap](https://www.taptap.cn/mobile)间接安装
##### ![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/1.png)
### 3.在TapTap中搜索Phigros直接等待安装即可
### 4.登录Phigros后同步云存档，确保为所需转移的存档账号，即可退出该游戏
### 5.为模拟器赋予Root权限![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/2.png)
### 6.获取安卓端同步后的存档文件 
##### 首页-系统应用-文件管理器![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/3.png)
##### 找到对应源文件并勾选![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/4.png)
##### 接着点击左上角菜单打开共享目录![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/5.png)打开Pictures文件夹，并移动至此![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/6.png)
##### 最后打开电脑端的共享文件夹即可查看![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/7.png)
##### 保留好该文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/8.png)
##### 此刻便可关闭所有程序了

## 第二步备份苹果端的Phigros（最好是刚下载的游戏）
##### 当然也可以使用爱思助手啦，这里使用[iMazing](https://imazing.com/zh/download)
### 1.打开AppStore为iPad安装最新版的Phigros，打开后是没有同步的版本![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/9.png)
### 2.将目标设备（苹果端，教程使用iPad Air 6）连接至电脑。
##### 由于iPad mini 6以后的新设备采用USB-C to USB-C的数据线
##### 有的电脑不含C口，即使电脑含有C口也可能因为硬件过旧无法识别设备
##### 可以采用USB-C to USB-A的数据线，比如小米手机充电线，试过成果，但有时候可能不稳定
##### 此教程采用USB-C转USB-A转接头连接原装数据线
##### 建议将电脑最稳定的口留出来并选择最稳定的插线姿势（有点玄学）
### 3.打开iMazing（建议保持最新版），选择目标设备，双击打开![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/10.png)![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/11.png)
##### 选择管理应用程序（也可以在工具中找到）
##### 备份Phigros![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/12.png)
##### 完成后获取Phigros.imazingapp文件

## 第三步使用自制工具一键将安卓xml文件转移到苹果plist文件
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/13.png)获得games.Pigeon.Phigros.plist文件

第四步导入苹果端（接下来的操作将覆盖苹果端的存档）
解压软件打开（此教程使用360压缩）第二步获取的备份文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/14.png)
选择Container-Library-Preferences使用第三步生成的文件并覆盖
接着再次打开iMazing，这次选择恢复数据文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/15.png)，选择覆盖后的文件，按照提示完成操作
请注意待设备恢复后重新开机时在iPad已进行部分设置界面要选择保留部分设置并继续（否则iPad将会被抹除！！！）
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/16.png)

## 第五步再次打开Phigros
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/17.png)![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/18.png)大功告成，最后别忘了重新打开查找功能哦！
