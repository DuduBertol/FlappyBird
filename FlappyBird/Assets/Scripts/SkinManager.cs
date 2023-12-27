using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    [Header("Background")]
    [SerializeField] GameObject bg_Panel;
    [SerializeField] GameObject bg_Selection;
    [SerializeField] List<float> bg_Pos = new List<float>();
    [SerializeField] int bg_index;

    [Header("Ground")]
    [SerializeField] GameObject ground_Panel;
    [SerializeField] GameObject ground_Selection;
    [SerializeField] List<float> ground_Pos = new List<float>();
    [SerializeField] int ground_index;
    
    [Header("Pipe")]
    [SerializeField] GameObject pipe_Panel;
    [SerializeField] GameObject pipe_Selection;
    [SerializeField] List<float> pipe_Pos = new List<float>();
    [SerializeField] int pipe_index;

    [Header("Player")]
    [SerializeField] GameObject player_Panel;
    [SerializeField] GameObject player_Selection;
    [SerializeField] List<float> player_Pos = new List<float>();
    [SerializeField] int player_index;


#region GENERAL BUTTONS
#endregion

#region BG BUTTONS

    public void Select_BGs()
    {
        LeanTween.moveX(bg_Panel.GetComponent<RectTransform>(), 0 , 0.5f).setEaseInOutExpo();
    }

    public void Return_BG()
    {
        LeanTween.moveX(bg_Panel.GetComponent<RectTransform>(), 2160 , 0.5f).setEaseInOutExpo();
        bg_index = 0;
        LeanTween.moveX(bg_Selection.GetComponent<RectTransform>(), bg_Pos[0], 0.3f).setEaseInOutExpo();
    }

    public void Right_BG()
    {
        bg_index++;

        if ( bg_index > bg_Pos.Count - 1)
        {
            bg_index = 0;
        }

        for(int i = 0; i < bg_Pos.Count; i++)
        {
            if(bg_index == i)
            {
                LeanTween.moveX(bg_Selection.GetComponent<RectTransform>(), bg_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

    public void Left_BG()
    {
        bg_index--;

        if (bg_index < 0)
        {
            bg_index = bg_Pos.Count - 1;
        }

        for(int i = 0; i < bg_Pos.Count; i++)
        {
            if(bg_index == i)
            {
                LeanTween.moveX(bg_Selection.GetComponent<RectTransform>(), bg_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

#endregion

#region GROUND BUTTONS

    public void Select_Ground()
    {
        LeanTween.moveX(ground_Panel.GetComponent<RectTransform>(), 0 , 0.5f).setEaseInOutExpo();
    }

    public void Return_Ground()
    {
        LeanTween.moveX(ground_Panel.GetComponent<RectTransform>(), 2160 , 0.5f).setEaseInOutExpo();
        ground_index = 0;
        LeanTween.moveX(ground_Selection.GetComponent<RectTransform>(), ground_Pos[0], 0.3f).setEaseInOutExpo();
    }

    public void Right_Ground()
    {
        ground_index++;

        if ( ground_index > ground_Pos.Count - 1)
        {
            ground_index = 0;
        }

        for(int i = 0; i < ground_Pos.Count; i++)
        {
            if(ground_index == i)
            {
                LeanTween.moveX(ground_Selection.GetComponent<RectTransform>(), ground_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

    public void Left_Ground()
    {
        ground_index--;

        if (ground_index < 0)
        {
            ground_index = ground_Pos.Count - 1;
        }

        for(int i = 0; i < ground_Pos.Count; i++)
        {
            if(ground_index == i)
            {
                LeanTween.moveX(ground_Selection.GetComponent<RectTransform>(), ground_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

#endregion

#region PIPE BUTTONS

    public void Select_Pipe()
    {
        LeanTween.moveX(pipe_Panel.GetComponent<RectTransform>(), 0 , 0.5f).setEaseInOutExpo();
    }

    public void Return_Pipe()
    {
        LeanTween.moveX(pipe_Panel.GetComponent<RectTransform>(), 2160 , 0.5f).setEaseInOutExpo();
        pipe_index = 0;
        LeanTween.moveX(pipe_Selection.GetComponent<RectTransform>(), pipe_Pos[0], 0.3f).setEaseInOutExpo();
    }

    public void Right_Pipe()
    {
        pipe_index++;

        if ( pipe_index > pipe_Pos.Count - 1)
        {
            pipe_index = 0;
        }

        for(int i = 0; i < pipe_Pos.Count; i++)
        {
            if(pipe_index == i)
            {
                LeanTween.moveX(pipe_Selection.GetComponent<RectTransform>(), pipe_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

    public void Left_Pipe()
    {
        pipe_index--;

        if (pipe_index < 0)
        {
            pipe_index = pipe_Pos.Count - 1;
        }

        for(int i = 0; i < pipe_Pos.Count; i++)
        {
            if(pipe_index == i)
            {
                LeanTween.moveX(pipe_Selection.GetComponent<RectTransform>(), pipe_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

#endregion

#region PLAYER BUTTONS

    public void Select_Player()
    {
        LeanTween.moveX(player_Panel.GetComponent<RectTransform>(), 0 , 0.5f).setEaseInOutExpo();
    }

    public void Return_Player()
    {
        LeanTween.moveX(player_Panel.GetComponent<RectTransform>(), 2160 , 0.5f).setEaseInOutExpo();
        player_index = 0;
        LeanTween.moveX(player_Selection.GetComponent<RectTransform>(), player_Pos[0], 0.3f).setEaseInOutExpo();
    }

    public void Right_Player()
    {
        player_index++;

        if ( player_index > player_Pos.Count - 1)
        {
            player_index = 0;
        }

        for(int i = 0; i < player_Pos.Count; i++)
        {
            if(player_index == i)
            {
                LeanTween.moveX(player_Selection.GetComponent<RectTransform>(), player_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

    public void Left_Player()
    {
        player_index--;

        if (player_index < 0)
        {
            player_index = player_Pos.Count - 1;
        }

        for(int i = 0; i < player_Pos.Count; i++)
        {
            if(player_index == i)
            {
                LeanTween.moveX(player_Selection.GetComponent<RectTransform>(), player_Pos[i], 0.3f).setEaseInOutExpo();
            }
            
        }
    }

#endregion

}
