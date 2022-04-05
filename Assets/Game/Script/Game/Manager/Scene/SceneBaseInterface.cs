namespace GameScene
{
    public interface SceneBaseInterface
    {
        void Awake();
        //初始化
        void OnInit();
        //显示
        void OnAwake();
        //启动
        void OnSatart();
        //显示
        void OnShow();
        //销毁
        void OnIDestroy();
    }

    /**
     * 场景相关介绍
     */
    public interface SceneBaseContorlInterface
    {
        
    }
}