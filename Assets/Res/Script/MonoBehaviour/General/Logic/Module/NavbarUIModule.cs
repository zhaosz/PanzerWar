using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavbarUIModule : MonoBehaviour {
    public void OpenSetting () {
        uGUI_QualitySetting.Open ();
    }
    public void JumpT1 () {
        Application.OpenURL ("https://www.youtube.com/watch?v=mbZA3l5upyI&list=UUbClsVr2iwR9tt5-4AGOBIA&index=5");
    }
    public void JumpT2 () {
        Application.OpenURL ("https://www.youtube.com/watch?v=DK3lQzjhvtE&list=UUbClsVr2iwR9tt5-4AGOBIA&index=7");
    }
    public void JumpT3 () {
        Application.OpenURL ("https://www.youtube.com/watch?v=oNTqLAt2UzY&list=UUbClsVr2iwR9tt5-4AGOBIA&index=1");
    }
    public void JumpGayHub () {
        Application.OpenURL ("http://github.com/Doreamonsky/PanzerWar/");
    }
}