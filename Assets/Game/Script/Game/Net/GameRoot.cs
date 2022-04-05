using UnityEngine;

namespace GameSystem.ServiceDataPro
{
    public class GameRoot
    {
        private GameRootServicePro m_gameRootPro = null;

        public static GameRoot CreateGameRoot()
        {
            var temp = new GameRoot();
            return temp;
        }

        private GameRoot()
        {
            m_gameRootPro = new GameRootServicePro();
        }

        public GameRootServicePro ServicePro
        {
            get { return m_gameRootPro; }
        }
    }
}