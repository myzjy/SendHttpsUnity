using System;
using System.Collections;
using GameData.Net;
using GameSystem.ServiceDataPro.Api;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
using Tools.Util;
using UniRx;
using UnityEngine;

namespace GameSystem.ServiceDataPro
{
    public class UserService : MasterUserPro
    {
        private LogInfoSBD m_logInfo;

        public LogInfoSBD LogInfoSBD
        {
            get { return m_logInfo; }
        }

        private void CreateLoginData(LoginSVO m_login)
        {
            if (m_logInfo == null)
            {
                m_logInfo = new LogInfoSBD();
            }

            m_logInfo.SetData(m_login, BaseDataTypeFinder);
        }

        //更新
        public void RequsetUpdateUser(Action func)
        {
            UserServiceApi api = new UserServiceApi();
            api.onSuccess = (res) =>
            {
                m_logInfo.UpdataUser(res, BaseDataTypeFinder);
                func.Execute();
            };
            api.onComplete = () => { };
            RequestJsonOnThread(api);
        }

        //用户数据取得
        public void RequsetLogin(Action func)
        {
            UserServiceApi api = new UserServiceApi();
            api.onSuccess = res =>
            {
                LoginSVO loginSvo = new LoginSVO();
                loginSvo.user = res;
                CreateLoginData(loginSvo);
            };
            api.Data = this;
            api.onComplete = () =>
            {
                StartCoroutineCreateLoginData(func);
            };

            RequestJsonOnThread(api);
        }

        private void StartCoroutineCreateLoginData(Action finish)
        {
            Observable.FromCoroutine(GetAllCreateLoginData).Subscribe(item => finish.Execute());
        }

        //创建登录数据
        private IEnumerator GetAllCreateLoginData()
        {
            // TheCatMintFieldDataVo theCatMintFieldDataVo = null;
            // RequestUserTheCatMintField(item => theCatMintFieldDataVo = item);
            // // yield return new WaitUntil(() => theCatMintFieldDataVo != null);
            // m_logInfo.CreateTheCatMintFieldData(theCatMintFieldDataVo, BaseDataTypeFinder);

            CatnipCollectionVO catnipCollectionVo = null;
            RequestUserCatnipCollection(res =>
            {
                catnipCollectionVo = res;
                BaseDataTypeFinder.AddServiceMasterData(catnipCollectionVo.GetType(),catnipCollectionVo);
            });
            yield return new WaitUntil(() => catnipCollectionVo != null);
            m_logInfo.CreateCatnipCollectionData(catnipCollectionVo, BaseDataTypeFinder);
           
            // CatnipLocalDataSVo catnipLocalDataSVo = null;
            // RequestUserCatnipCollection(res => catnipLocalDataSVo = res);
            // yield return new WaitUntil(() => catnipLocalDataSVo != null);
            // m_logInfo.CreateCatnipLocalData(catnipLocalDataSVo, BaseDataTypeFinder);

            // m_logInfo.CreateUserData();
        }


        private void RequestUserTheCatMintField(Action<TheCatMintFieldDataVo> resAction)
        {
            // api.Data=BaseDataTypeFinder.FindBaseDatas<>()
            // var api = CreateGet();
            //猫薄荷田
        }

        public void RequestUserCatnipCollection(Action<CatnipCollectionVO> resAction)
        {
            var api = CreateGet();
            //采集猫薄荷
            RequesServiceJson<CatnipCollectionVO>("api/catnip/catnip_collection/", resAction);
        }

        private void RequestUserCatnipCollection(Action<CatnipLocalDataSVo> resAction)
        {
            var api = CreateGet();
            //猫薄荷
            RequesServiceJson<CatnipLocalDataSVo>("api/catnip/catnip_data_base/", resAction);
        }
        public void RequestCatnipJson(Action<CatnipLocalDataSVo> finsh)
        {
            ServericeBase m_servericeBase = ServericeBase.ServericeBasePost();

            m_servericeBase.AddPayload("add_catnip",1);
            //采集猫薄荷
            RequesServiceJson<CatnipLocalDataSVo>("api/catnip/catnip_data_base",m_servericeBase, finsh);
        }
        private CatnipLocalDataSBD m_CatnipLocalDataSBD = null;

        public void CreateCatnipLocalData(CatnipLocalDataSVo _catnip, Action<CatnipLocalDataSBD> resFinder)
        {
            if (m_CatnipLocalDataSBD == null)
            {
                m_CatnipLocalDataSBD = new CatnipLocalDataSBD();
            }
            m_CatnipLocalDataSBD.SetData(_catnip,BaseDataTypeFinder);
            resFinder.Execute(m_CatnipLocalDataSBD);
        }
    }
}