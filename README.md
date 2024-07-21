# 《软件PhigrosCrossPlatformDataMigrator介绍》
##### 欢迎使用Phigros跨系统存档迁移器 - 由SweelLong开发
##### 功能是将安卓系统的存档数据文件（*.xml）转移至苹果系统的数据文件（*.plist）
##### 目前仅支持将安卓存档转移为苹果存档
##### 旨在解决苹果端不能使用云存档功能

##### 源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
##### 新文件：games.Pigeon.Phigros.plist


------------------------------------------------------

#《Phigros-解决苹果端无法云同步问题》

本人高考后入手新iPad想玩继续游玩该游戏
发现苹果端无法同步之前的数据就多方查询
结合多种资料整合出这种方案以跨系统同步
目前还不打算使用安卓设备故没有逆向转移
如果有逆向转移存档的需求则可以联系本人
由于安卓端同步功能是正常的所以有此教程
目标是将安卓端的存档数据文件转至苹果端
源文件：com.PigeonGames.Phigros.v2.playerprefs.xml
新文件：games.Pigeon.Phigros.plist

第一步获取安卓端存档：
提取的方法有很多哈，需要Root（直接操作）和无需Root（连接电脑）的都有
网络上有一种安卓手机无root的方法https://docs.qq.com/doc/DZm9FSUZSRUZBekhB
我这里提供电脑直接获取的方法——模拟器，前提是需要开启虚拟化
本教程使用雷电模拟器9（https://www.ldmnq.com）做演示：
1.安装模拟器，这里就不做过多解释了，直接跳过
2.安装Phigros，如果有Phigros.apk就直接安装，此教程先安装TapTap（https://www.taptap.cn/mobile）
[图片1]
3.在TapTap中搜索Phigros直接等待安装即可
4.登录Phigros后同步云存档，确保为所需转移的存档账号，即可退出该游戏
5.为模拟器赋予Root权限[图片2]
6.获取安卓端同步后的存档文件：
首页-系统应用-文件管理器[图片3]
找到对应源文件并勾选[图片4]
接着点击左上角菜单打开共享目录[图片5]打开Pictures文件夹，并移动至此[图片6]
最后打开电脑端的共享文件夹即可查看[图片7]
保留好该文件[图片8]
此刻便可关闭所有程序了

第二步备份苹果端的Phigros（最好是刚下载的游戏）
当然也可以使用爱思助手啦，这里使用iMazing.exe（https://imazing.com/zh/download）
1.打开AppStore为iPad安装最新版的Phigros，打开后是没有同步的版本[图片9]
2.将目标设备（苹果端，教程使用iPad Air 6）连接至电脑。
由于iPad mini 6以后的新设备采用USB-C to USB-C的数据线
有的电脑不含C口，即使电脑含有C口也可能因为硬件过旧无法识别设备
也可以采用USB-C to USB-A的数据线，比如小米手机充电线，试过成果，但有时候可能不稳定
此教程采用USB-C转USB-A转接头连接原装数据线
建议将电脑最稳定的口留出来并选择最稳定的插线姿势（有点玄学）
3.打开iMazing（建议保持最新版），选择目标设备，双击打开[图片10]
选择管理应用程序（也可以在工具中找到）
备份Phigros[图片12]
完成后获取Phigros.imazingapp文件

第三步使用自制工具一键将安卓xml文件转移到苹果plist文件
[图片13]获得games.Pigeon.Phigros.plist文件

第四步导入苹果端（接下来的操作将覆盖苹果端的存档）
解压软件打开（此教程使用360压缩）第二步获取的备份文件[图片14]
选择Container-Library-Preferences使用第三步生成的文件并覆盖
接着再次打开iMazing，这次选择恢复数据文件[图片15]，选择覆盖后的文件，按照提示完成操作
请注意待设备恢复后重新开机时在iPad已进行部分设置界面要选择保留部分设置并继续（非则iPad将会被抹除！！！）
[图片16]

第五步再次打开Phigros[图片17]大功告成，最后别忘了重新打开查找功能哦！
