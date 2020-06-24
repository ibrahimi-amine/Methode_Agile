using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework

public class Pausetest
{

   [Test]
   public void ispausedreturnstrue(){
    Input.GetKeyDown(KeyCode.Escape)=true;
       //arrange
       var PauseMenu = new PauseMenu();
       //act
       PauseMenu.update(isPaused=true);
       //assert
       Assert.AreEqual(isPaused,false);
   }


    [Test]
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
