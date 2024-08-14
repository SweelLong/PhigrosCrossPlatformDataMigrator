# 目录（图片不可见?试试[steamcommunity302](https://www.dogfight360.com/blog/686)反代）
- [软件介绍](#软件PhigrosCrossPlatformDataMigrator介绍)
- [安卓 -> 苹果](#Phigros-解决苹果端无法云同步问题)
- [苹果 -> 安卓](#苹果端转回安卓端进行云存档的逆向操作)

# 软件PhigrosCrossPlatformDataMigrator介绍
- 欢迎使用Phigros跨系统存档迁移器 - 由SweelLong开发
- 功能是将安卓系统的存档数据文件（*.xml）转移至苹果系统的数据文件（*.plist）
- 所以可以认为这是xml转plist的简单工具
- 目前仅支持将安卓存档转移为苹果存档
- 旨在解决苹果端不能使用云存档功能

- 源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
- 新文件：games.Pigeon.Phigros.plist

### [点击立即前往下载](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/releases/tag/v2.0.0.0)

---

# Phigros-解决苹果端无法云同步问题

- 结合多种资料整合出这种方案以跨系统同步
- 由于安卓端同步功能是正常的所以有此教程
- 目标是将安卓端的存档数据文件转至苹果端
- v2.1最新修复苹果->安卓产生的存档无法使用的问题
- 最新版支持安卓苹果存档互转，注意旧版仅支持安卓转苹果！
- 源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
- 新文件：games.Pigeon.Phigros.plist
---
- 准备工具
- 操作系统：Windows系统、IOS系统
- 硬件需求：USB-C(旧版lighting) - USB-A数据线、支持虚拟化的电脑、苹果端设备
- 软件需求：安卓手机模拟器.exe、Phigros.apk、phigros.ipa、iMazing.exe、Phigros跨系统存档迁移器.exe、压缩软件.exe
- 下载地址
- 雷电模拟器9：www.ldmnq.com
- TapTap：www.taptap.cn/mobile
- iMazing：imazing.com/zh/download
- Phigros跨系统存档迁移器：上面自取哦
---
## 第一步获取安卓端存档：
- 提取的方法有很多哈，需要Root（直接操作）和无需Root（连接电脑）的都有
- 网络上有一种[安卓手机无需root的方法](https://docs.qq.com/doc/DZm9FSUZSRUZBekhB)
- 我这里提供电脑直接获取的方法——模拟器，前提是需要开启虚拟化
- 本教程使用[雷电模拟器9](https://www.ldmnq.com)做演示：
- 1.安装模拟器，这里就不做过多解释了，直接跳过
- 2.安装Phigros，如果有Phigros.apk就直接安装，此教程使用[TapTap](https://www.taptap.cn/mobile)间接安装
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/1.png)
- 3.在TapTap中搜索Phigros直接等待安装即可
- 4.登录Phigros后同步云存档，确保为所需转移的存档账号，即可退出该游戏
- 5.为模拟器赋予Root权限![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/2.png)
-  6.获取安卓端同步后的存档文件 
- 首页-系统应用-文件管理器![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/3.png)
- 找到对应源文件并勾选![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/4.png)
- 接着点击左上角菜单打开共享目录![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/5.png)打开Pictures文件夹，并移动至此![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/6.png)
- 最后打开电脑端的共享文件夹即可查看![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/7.png)
- 保留好该文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/8.png)
- 此刻便可关闭所有程序了

## 第二步备份苹果端的Phigros（最好是刚下载的游戏）
- 当然也可以使用爱思助手啦，这里使用[iMazing](https://imazing.com/zh/download)
- 1.打开AppStore为iPad安装最新版的Phigros，打开后是没有同步的版本![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/9.png)
- 2.将目标设备（苹果端，教程使用iPad Air 6）连接至电脑。
- 由于iPad 10以后的新设备采用USB-C to USB-C的数据线
- 有的电脑不含C口，即使电脑含有C口也可能因为硬件过旧无法识别设备
- 可以采用USB-C to USB-A的数据线，比如小米手机充电线，试过成果，但有时候可能不稳定
- 此教程采用USB-C转USB-A转接头连接原装数据线
- 建议将电脑最稳定的口留出来并选择最稳定的插线姿势（有点玄学）
- 3.打开iMazing（建议保持最新版），选择目标设备，双击打开![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/10.png)![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/11.png)
- 选择管理应用程序（也可以在工具中找到）
- 备份Phigros![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/12.png)
- 完成后获取Phigros.imazingapp文件

## 第三步使用自制工具一键将安卓xml文件转移到苹果plist文件
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/13.png)获得games.Pigeon.Phigros.plist文件

## 第四步导入苹果端（接下来的操作将覆盖苹果端的存档）
- 解压软件打开（此教程使用360压缩）第二步获取的备份文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/14.png)
- 选择Container-Library-Preferences使用第三步生成的文件并覆盖
- 接着再次打开iMazing，这次选择恢复数据文件![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/15.png)，选择覆盖后的文件，按照提示v完成操作
- 请注意待设备恢复后重新开机时在iPad已进行部分设置界面要选择保留部分设置并继续（否则iPad将会被抹除！！！）
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/16.png)

## 第五步再次打开Phigros
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/17.png)![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/18.png)
- 大功告成，最后别忘了重新打开查找功能哦！

---

# 苹果端转回安卓端进行云存档的逆向操作

- 准备工具
- 操作系统：Windows系统、IOS系统
- 硬件需求：USB-C(旧版lighting) - USB-A数据线、支持虚拟化的电脑、苹果端设备
- 软件需求：安卓手机模拟器.exe、Phigros.apk、phigros.ipa、iMazing.exe、Phigros跨系统存档迁移器.exe、压缩软件.exe
- 下载地址
- 雷电模拟器9：www.ldmnq.com
- TapTap：www.taptap.cn/mobile
- iMazing：imazing.com/zh/download
- Phigros跨系统存档迁移器：上面自取哦

## 第一步获取苹果端的存档文件
- 同理，打开iMzing备份本地Phigros存档
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/10.png)
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/11.png)
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/12.png)
- 完成后获取Phigros.imazingapp文件
- 接着使用压缩软件打开获取到的文件
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/14.png)
- 在Container-Library-Preferences中解压出games.Pigeon.Phigros.plist文件
- 此刻成功获取到了苹果端的存档文件！

## 第二步将存档迁移至安卓端
- 打开最新版本工具Phigros跨系统存档迁移器_v2.1_x64.exe
- 将获取到的苹果端存档games.Pigeon.Phigros.plist放置到工具所在的文件夹，并打开工具
- 在选择迁移模式的时候，输入2回车
![7f69701249d51c6234b2eb93c4c82ae5](https://github.com/user-attachments/assets/3020d0cc-9c9a-405b-9352-419a9f2feb67)
  ![008bbde2a9f4ff8e1f22d7affbd2bbc4](https://github.com/user-attachments/assets/a9ff76c7-eaa9-4896-a48d-091ca035ba08)
- 即可获得上图所示③的安卓存档文件com.PigeonGames.Phigros.v2.playerprefs.xml

## 第三步将安卓存档导入模拟器并同步
- 确保模拟器启用了ROOT权限且安装了Phigros（不会的请看上一个模块）
- 将迁移后的安卓存档文件导入（粘贴）到共享文件夹中
![icon](https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator/blob/main/Phigros-%E8%A7%A3%E5%86%B3%E8%8B%B9%E6%9E%9C%E7%AB%AF%E6%97%A0%E6%B3%95%E4%BA%91%E5%90%8C%E6%AD%A5%E9%97%AE%E9%A2%98/7.png)
- 在模拟器中找到共享文件夹，左上角菜单，选择内部共享储存空间
![QQ_1722221795461](https://github.com/user-attachments/assets/adecd407-db3f-451f-97ff-e2a12b8e3dbe)
- 打开Pictures文件夹，即可在模拟器中看到导入的存档文件，请将该文件选中
![QQ_1722221881843](https://github.com/user-attachments/assets/81901572-0000-45a1-b09c-da431d4f39b0)
- 接着点击菜单，根目录-data-data-com.PigeonGames.Phigros-shared_prefs并将文件移至此处，并确保日期与移动时间保持一致
![QQ_1722222028131](https://github.com/user-attachments/assets/ee33ffa1-63b8-412d-adff-3a59d4e4e47f)
![QQ_1722222080359](https://github.com/user-attachments/assets/8dc883eb-ece9-4375-abec-25342bce6e18)
- 再次打开游戏，大功告成！

## 倘若出现文件大小过小的情况的解决方案
用爱思助手打开plist文件，以xml形式导出，确保能够用文本编辑器正常打开
删除以下内容：
![1c3a3fd976b0d8f54cd41e57eab384de](https://github.com/user-attachments/assets/50865005-c941-4c49-a30c-6ad3d88ffe2f)
![9e33498b52c6a18bae37b1a5ffa0fcfc](https://github.com/user-attachments/assets/4c99bf8c-55ef-4345-a89f-c39ce6a7c683)
![2093b01291c7342dca3e86b563c681a7](https://github.com/user-attachments/assets/92a36c65-86fe-417f-9d49-a50bc76299cd)
![b7490858d503d682b6d3e56c6964b2d5](https://github.com/user-attachments/assets/3e841a10-3ea2-44e4-b3f5-1af776f97534)
![622992be96a26dd8e4d6dd32fd828af1](https://github.com/user-attachments/assets/7499c155-dac2-4c6e-9aaf-207665a5d3de)
保存后，用转移软件转移这个新保存的plist文件即可（由于Phigros恢复云存档功能，故我不会将软件升级以解决！）
