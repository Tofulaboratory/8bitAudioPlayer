using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TofuLab
{
    public class AudioManager : SingletonMonoBehaviour<AudioManager>
    {
        private Dictionary<string, AudioSource> BGMSource = new Dictionary<string, AudioSource>();
        private readonly string _bgmFilePath = "Audio/BGM";

        protected override void Awake()
        {
            base.Awake();
            RegisterAudioData();
        }

        private void RegisterAudioData()
        {
            var bgmData = Resources.LoadAll(_bgmFilePath);

            foreach (AudioClip bgm in bgmData)
            {
                var audioSource = gameObject.AddComponent<AudioSource>();
                BGMSource[bgm.name] = audioSource;
                BGMSource[bgm.name].clip = bgm;
            }
        }

        /// <summary>
        /// bgmをならす
        /// </summary>
        public void PlayBGM(string name, bool isLoop = true, float volume = 1)
        {
            if (!BGMSource.ContainsKey(name)) return;
            if (BGMSource[name].isPlaying) return;

            BGMSource[name].loop = isLoop;
            BGMSource[name].volume = volume;
            BGMSource[name].Play();
        }

        /// <summary>
        /// bgmを止める
        /// </summary>
        public void StopBGM(string name)
        {
            if (!BGMSource.ContainsKey(name)) return;
            if (!BGMSource[name].isPlaying) return;

            BGMSource[name].Stop();
        }

        /// <summary>
        /// spectrum dataの取得
        /// </summary>
        public float[] GetBGMSpectrumData(string name, int numSumples)
        {
            if (!BGMSource.ContainsKey(name)) return null;

            float[] spectrum = new float[numSumples];
            BGMSource[name].GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
            Debug.Log(spectrum);
            return spectrum;
        }
    }
}