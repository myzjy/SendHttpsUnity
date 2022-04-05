namespace Game.GameSystem
{
    public  class ModelDatraIn
    {
        //对应存储Json格式字符串
        public virtual string JsonData { get; set; }

        //当前继承数据json格式
        protected virtual string ToJson(bool isPretty = false)
        {
            //初始状态
            return "";
        }

        public override string ToString()
        {
            return ToJson();
        }
    }
}