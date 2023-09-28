using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

namespace Longlq
{
    public class GameManager : Singleton<GameManager>
    {
        public string[] levels;

    }
    public enum GameSatte
    { 
          Home,
          Play,
          Pause
    }
}

