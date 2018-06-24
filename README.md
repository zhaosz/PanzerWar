[![license](http://img.shields.io/badge/license-MIT-blue.svg)]()


# Synopsis 
An open source tank game made by Unity3D game engine.

这是一个由Unity3D 开发的开源坦克游戏。

点击查看中文版项目配置: [点击查看 中文版ReadMe](https://github.com/Doreamonsky/PanzerWar/wiki/配置项目)


> Panzer War used to be a commercial  mobile tank combat game. However,the developer won't have much time to work on it.So the online servers are stopped,and the game become an open source one.

You can download released version from 
[GooglePlay](https://play.google.com/store/apps/details?id=com.shanghaiwindy.PanzerWarOpenSource)

------------

 ![GameScreenShot](https://github.com/Doreamonsky/Markdown/blob/master/Screenshot.jpg?raw=true)
 

## Installation 
####  Clone
> 1. Install git large file storage [Download git-lfs](https://git-lfs.github.com)
> 2. Use git command: git clone https://github.com/Doreamonsky/PanzerWar.git 

*Then open the project with Unity3D (Unity 2017.x)*
#### Build  AssetBundles
>1. Open menu Tools/ShanghaiWindy/Build/SceneBuilder .
>2. Switch platform to your building target.
>3. Click Build Sub-Assets.

*Then you can run the game from scene "StartUp"*

## Reference
### Wiki 
WIKI Page on GitHub : [View it](https://github.com/Doreamonsky/PanzerWar/wiki)
### Tutorials 
1.videos for beginner.
Videos on [YouTube](https://youtu.be/mbZA3l5upyI) 

2.Vehicle Configures in Unity3D
Videos on [YouTube](https://www.youtube.com/watch?v=DK3lQzjhvtE) 


## Demo Codes
### Instantiate existing vehicle.
 ![GameScreenShot](https://github.com/Doreamonsky/Markdown/blob/master/Readme/01.png?raw=true)
#### Code
```C sharp
using UnityEngine;

public class illustration : MonoBehaviour {
	void Start () {
	    GameDataManager.OfflineMode = true; // Use offline
	    
        GameObject newVehicle = new GameObject("Vehicle"); 
        TankInitSystem initSystem = newVehicle.AddComponent<TankInitSystem>(); // Add vehicle init system
        initSystem.VehicleName = "T-44"; //Set vehicle name
        initSystem._InstanceNetType = InstanceNetType.GameNetWorkOffline; // Switch vehicle to offline mode
        initSystem.BulletCountList = new int[3]{ //Set Bullet counts 
            35,15,5
        };
        initSystem.InitTankInitSystem(); // Load all data 
	}

}
```

## Contributors
[Wang [Doreamonsky]](http://vk.com/doreamonsky "Wang [Doreamonsky]")

[Kovalenko Vlad](https://vk.com/iso_slacker_yt "Kovalenko Vlad")
