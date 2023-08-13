# EasyClipper
マウスカーソルが、ウィンドウの外に出るのを防止するツールです。

主に、ウィンドウモードでのゲームプレイ中に、マウスカーソルがウィンドウの外に飛び出してゲーム体験を損なわないようにするのを目的に作成されています。


## 動作環境
- Windows 10以上
- [.NET Desktop Runtime 6.0](https://dotnet.microsoft.com/ja-jp/download/dotnet/6.0)


## 起動方法
(1) [.NET Desktop Runtime 6.0](https://dotnet.microsoft.com/ja-jp/download/dotnet/6.0) がインストールされていない場合は、インストールを行ってください。

(2) 適当なフォルダにEasyClipperのアーカイブファイルを解凍し、EasyClipper.exeを起動してください。


## 使用方法
"Drag & Drop to Target Window"ボタンから、マウスカーソル範囲を制限したいウィンドウを
ドラッグ＆ドロップで指定してください。

指定した後は、そのウィンドウをアクティブにするとマウスカーソル範囲制限が有効になります。

制限を解除するには、下記の方法のいずれかで解除してください。

- 制限対象のウィンドウを終了させる。
- ALT+TabキーでEasyClipperウィンドウをアクティブにし、"Stop"ボタンをクリックする。


## アンインストール方法
EasyClipper.exeを解凍したフォルダを削除してください。

また、設定ファイルがドキュメントフォルダ内の "RadianTools\EasyClipper\EasyClipper.config.json" に作成されるので、不要であれば削除してください。

（一般的なフルパスは、"C:\Users\ユーザー名\Documents\RadianTools\EasyClipper\EasyClipper.config.json" となります）

## ライセンス情報
EasyClipperのライセンスについては、[LICENSE](/LICENSE) を参照してください。

EasyClipperで使用されているライブラリのライセンスについては、[third-party-notices.txt](/third-party-notices.txt) を参照してください。
