using System;
using UnityEngine;

namespace Game.Attribute.BuildAttribute
{
    [AttributeUsage(
         AttributeTargets.Class |AttributeTargets.All|
        AttributeTargets.Property | AttributeTargets.Field,
        AllowMultiple = true)]
    public sealed class ImageBuildAttribute : System.Attribute
    {
        public string tip;
        public string tranfrom_String;
        private  GameObject _tip;
        public GameObject TipsObj
        {
            get { return _tip; }
            set { _tip = value; }
        }

        public ImageBuildAttribute()
        {
        }

        public ImageBuildAttribute(string _ti)
        {
            this.tip = _ti;
        }
        public ImageBuildAttribute(string _tips,string _ti)
        :this(_tips)
        {
            this.tip = _ti;
        }

        public ImageBuildAttribute(GameObject _ti)
        {
            this.TipsObj = _ti;
        }
    }
}