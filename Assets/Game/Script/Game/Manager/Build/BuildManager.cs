using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Assets.Script.Tools;
using Game.UI.Common;
using GameScene;
using GameSystem.BuildType;
using GameSystem.ServiceDataPro;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
using Tools.Util;
using Unity.Linq;
using UnityEngine;
using ZJY.NetData;

namespace Game.GameManager
{
    /// <summary>
    /// 建筑管理
    /// </summary>
    public class BuildManager : BasePageView
    {
        /// <summary>
        /// 生成的物体
        /// </summary>
  

        private readonly BuildType[] StateValues = (BuildType[]) System.Enum.GetValues(typeof(BuildType));
        [SerializeField] private Canvas _buildCanvas = null;
        private CatnipCollectionDataPro m_CatnipCollectionPro = null;
        
        public void SetCanvas(Canvas m_buildCanvas)
        {
            _buildCanvas = m_buildCanvas;
        }


        // /// <summary>
        // /// 创建
        // /// </summary>
        // public void CreateObj(GameObject _data, BuildOrQiType _build)
        // {
        //     var obj = UnityGamesTools.InstanceTransformScript<BuildBaseObj>(_data, this.transform);
        //     obj.CreateTheCatCareer();
        //     obj.ChangeThecatCareer(_build);
        // }

    

        private void AddOnViewEventAction()
        {
            AddOnUIViewEventHandler<BuildType>("OnClickCantipCollection", OnClickCantipCollection);
        }

        private void OnClickCantipCollection(BuildType m_type)
        {
            // DispatchUIViewEvent("RefureCatnipLoalItem",null);
        }

        private readonly List<GameObject> _buildList = new List<GameObject>();

       
    }
}