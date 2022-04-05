using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using GameScene;
using Newtonsoft.Json;
using Scene.Type;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Manager.Game
{
    public class BypassCertificate : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            return true;
        }
    }

    public class GameStart : SceneBase
    {
        // public static GameStart I = null;
        public static bool Validator(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors policyErrors)
        {
            //Debug.Log("Validation successful!");
            return true;
        }

        protected override IEnumerator Prepare()
        {
            yield return base.Prepare();
            yield return GameSatartIE();
        }


        private GameManager m_gameManager = null;

        protected GameManager GetGameManager
        {
            get { return m_gameManager; }
        }


        /// <summary>
        /// 携程启动 gameStart,创建
        /// </summary>
        /// <returns></returns>
        private IEnumerator GameSatartIE()
        {
            ChangeScene(SceneType.GameScene, SceneType.Start);
            yield return null;
        }
    }
}