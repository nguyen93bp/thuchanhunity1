using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class tictactoecode : MonoBehaviour
{
    Boolean cheker;
    int plusone;
    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;
    public Text btnResetGame = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;
    public Text btnPlayerX;
    public Text btnPlayerO;
    public Text txtPlayerX;

    public Text txtPlayerO;

    public void score()
    {
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.green;
            btnText5.color = Color.green;
            btnText7.color = Color.green;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText1.color = Color.yellow;
            btnText2.color = Color.yellow;
            btnText3.color = Color.yellow;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText7.color = Color.cyan;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText1.color = Color.green;
            btnText2.color = Color.green;
            btnText3.color = Color.green;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "the winner is player x";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }


        //===================playero===================================================================================================================
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.green;
            btnText5.color = Color.green;
            btnText7.color = Color.green;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText1.color = Color.yellow;
            btnText2.color = Color.yellow;
            btnText3.color = Color.yellow;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText7.color = Color.cyan;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText1.color = Color.green;
            btnText2.color = Color.green;
            btnText3.color = Color.green;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "the winner is player o";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

    }
    public void btnText1_Click()
    {
        if (cheker == false)
        {
            btnText1.text = "X";
            cheker = true;

        }
        else
        {
            btnText1.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText2_Click()
    {
        if (cheker == false)
        {
            btnText2.text = "X";
            cheker = true;

        }
        else
        {
            btnText2.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText3_Click()
    {
        if (cheker == false)
        {
            btnText3.text = "X";
            cheker = true;

        }
        else
        {
            btnText3.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText4_Click()
    {
        if (cheker == false)
        {
            btnText4.text = "X";
            cheker = true;

        }
        else
        {
            btnText4.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText5_Click()
    {
        if (cheker == false)
        {
            btnText5.text = "X";
            cheker = true;

        }
        else
        {
            btnText5.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText6_Click()
    {
        if (cheker == false)
        {
            btnText6.text = "X";
            cheker = true;

        }
        else
        {
            btnText6.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText7_Click()
    {
        if (cheker == false)
        {
            btnText7.text = "X";
            cheker = true;

        }
        else
        {
            btnText7.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText8_Click()
    {
        if (cheker == false)
        {
            btnText8.text = "X";
            cheker = true;

        }
        else
        {
            btnText8.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnText9_Click()
    {
        if (cheker == false)
        {
            btnText9.text = "X";
            cheker = true;

        }
        else
        {
            btnText9.text = "O";
            cheker = false;
        }
        score();
    }
    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;

    }
    public void btnNewGame_Click()
    {
        btnResetGame_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }


}
