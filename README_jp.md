# SimpleFolderIcon

[![GitHub all releases](https://img.shields.io/github/downloads/SeaeeesSan/SimpleFolderIcon/total)](https://github.com/SeaeeesSan/SimpleFolderIcon/releases)
[![GitHub license](https://img.shields.io/github/license/SeaeeesSan/SimpleFolderIcon)](https://github.com/SeaeeesSan/SimpleFolderIcon/blob/master/LICENSE)

![image](https://github.com/user-attachments/assets/dc74f5c8-680e-427b-bc69-fe61ecf8bc0e)

## Features
 
プロジェクトウィンドウの特定のフォルダのアイコンを見やすく変更します。

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

`Assets/SimpleFolderIcon/Icons/Default/Default.png`がアイコンテンプレートです。  
アイコンを追加する場合は`Assets/SimpleFolderIcon/Icons/`に.png形式のアイコン（推奨256×256）を入れてください。

`Assets/SimpleFolderIcon/Icons/`内のアイコンのファイル名が、そのまま適用されるフォルダの名前になっています。

オプション：複数の名前のフォルダに一つのアイコンを割り当てたい時は、`Assets/SimpleFolderIcon/Icons/Default/FolderIconSO.asset`を`Assets/SimpleFolderIcon/Icons/`内にコピーし、アイコンと名前を割り当ててください。

**画像をリネーム・削除して、アイコンをカスタマイズ可能です。**

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
- [Releases](https://github.com/SeaeeesSan/SimpleFolderIcon/releases)から.unitypackage形式でダウンロード


## License
 
- [MIT license](https://github.com/SeaeeesSan/SimpleFolderIcon/blob/master/LICENSE)
- フォルダアイコンの一部に、[Material design icons](https://fonts.google.com/icons)を使用しています。
