using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    //[SerializeField] List<GameObject> BGS = new List<GameObject>();
    [SerializeField] GameObject BG_Panel;
    [SerializeField] GameObject BG_Selection;

#region GENERAL BUTTONS
#endregion

#region BG BUTTONS

    public void Select_BGs()
    {

        BG_Panel.SetActive(true);
        LeanTween.moveX(BG_Panel.GetComponent<RectTransform>(), 0 , 0.5f).setEaseInOutExpo();
    }

    public void Return_BG()
    {
        LeanTween.moveX(BG_Panel.GetComponent<RectTransform>(), -2160 , 0.5f).setEaseInOutExpo();
        BG_Panel.SetActive(false);
    }

    public void Right_BG()
    {
        LeanTween.moveX(BG_Selection.GetComponent<RectTransform>(), BG_Selection.GetComponent<RectTransform>().transform.localPosition.x - 2160 , 0.5f).setEaseInOutExpo();
        //CRIAR LIST DAS POSITION DOS BG - PARA NAO CORRER BUGS
        //QUANDO SPAMO BOTÃO DE PASSAR, ACABA BUGANDO PQ PEGA A POSIÇÃO ATUAL DA BG_SELECTION
        //LeanTween.moveX(BG_Selection.GetComponent<RectTransform>(), BG_Selection.GetComponent<RectTransform>().position.x - 2160 , 1f).setEaseInExpo();
    }

    public void Left_BG()
    {
        LeanTween.moveX(BG_Selection.GetComponent<RectTransform>(), BG_Selection.GetComponent<RectTransform>().transform.localPosition.x + 2160 , 0.5f).setEaseInOutExpo();
    }

#endregion

#region GROUND BUTTONS
#endregion

#region PIPE BUTTONS
#endregion

#region PLAYER BUTTONS
#endregion

    

    public void Select_Grouds()
    {
        
    }

    public void Select_Pipes()
    {
        
    }

    public void Select_Players()
    {
        
    }

}
