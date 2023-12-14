# 概要
・サウンドを8bit風に再生する機能です

・リアルタイムに波を変換しています

# 使い方
![スクリーンショット 2023-12-14 202053](https://github.com/Tofulaboratory/8bitAudioPlayer/assets/113935739/f564c6ec-1f91-4df2-9507-d8d3e9c9e6f1)

(1) ディレクトリ、アセット、シーン準備(画像参考)

・Resources/Audio/BGMディレクトリをAssetsディレクトリ以下に作成

・BGMディレクトリ以下にAudioアセットを配置

・AudioManagerをアタッチしたゲームオブジェクトをシーン上に設置

・EightBitAudioPlayerを任意のゲームオブジェクトにアタッチする

(2) EightBitAudioPlayerのパラメータ設定

▼BGMName

・再生するAudioアセット名

▼IsPlaying

・変換するかどうか

▼WaveType

・変換後の波形

▼Threshold

・波に変換する音量閾値

▼Ratio

・元の音と変換後の音の比率(1で変換後のみ)

▼EightBitVolume

・変換後の音量

▼Pitch

・変換後の波のピッチ
