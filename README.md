# SimpleFolderIcon

[![GitHub all releases](https://img.shields.io/github/downloads/SeaeeesSan/SimpleFolderIcon/total)](https://github.com/SeaeeesSan/SimpleFolderIcon/releases)
[![GitHub license](https://img.shields.io/github/license/SeaeeesSan/SimpleFolderIcon)](https://github.com/SeaeeesSan/SimpleFolderIcon/blob/master/LICENSE)
[![openupm](https://img.shields.io/npm/v/com.seaeees.simple-folder-icon?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.seaeees.simple-folder-icon/)

### 日本語版は[こちら](README_jp.md)

![image](https://github.com/user-attachments/assets/dc74f5c8-680e-427b-bc69-fe61ecf8bc0e)


## Features

**SimpleFolderIcon** enables you to customize the color and the icon label of your folders in the Unity project browser.

### Folder List

- Animations
- Audio
- Editor
- Editor Default Resources
- Fonts
- Gizmos
- Materials
- Models
- Plugins
- Prefabs
- Presets
- Resources
- Scenes
- Scripts
- Settings
- Shaders
- Sprites
- StreamingAssets
- Textures

## Customize

`Assets/SimpleFolderIcon/Icons/Default/Default.png` is the sample icon file.
Set your own icons by adding the **PNG** format images in `Assets/SimpleFolderIcon/Icons/`.
The preferred size of the image is **256x256**.

File names of the icon images in `Assets/SimpleFolderIcon/Icons/` are associated with the names of the folder that will be customize.

Optional: if you want to use one image for multiple folders, you may copy `Assets/SimpleFolderIcon/Icons/Default/FolderIconSO.asset` into `Assets/SimpleFolderIcon/Icons/`, then in the Inspector: assign an icon & add as many folder names to the list as you want.

**Just simply customize the icons by renaming or deleting the sample image files!**


 
## Installation
Unity2019.4 or later

### using Git URL
- Window > Package Manager > Add package from git URL...

```
https://github.com/SeaeeesSan/SimpleFolderIcon.git?path=Packages/com.seaeees.simple-folder-icon
```

### Install via OpenUPM
```bash
openupm add com.seaeees.simple-folder-icon
```

### Install manually (.unitypackage)
- Download the package from [Releases](https://github.com/SeaeeesSan/SimpleFolderIcon/releases).

 
## License
 
- [MIT license](https://github.com/SeaeeesSan/SimpleFolderIcon/blob/master/LICENSE)
- Some of the icons are from [Material design icons](https://fonts.google.com/icons).
