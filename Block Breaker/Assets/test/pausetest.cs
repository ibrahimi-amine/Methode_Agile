using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausetest
{

   public void ispausedreturnstrue(){
    Input.GetKeyDown(KeyCode.Escape)=true;
       //arrange
       var PauseMenu = new PauseMenu();
       //act
       PauseMenu.update(isPaused=true);
       //assert
       Assert.AreEqual(isPaused,false);
   }

    public void ispausedreturnsfalse(){
    Input.GetKeyDown(KeyCode.Escape)=true;
       //arrange
       var PauseMenu = new PauseMenu();
       //act
       PauseMenu.update(isPaused=false);
       //assert
       Assert.AreEqual(ispaused,true);
      }

}
