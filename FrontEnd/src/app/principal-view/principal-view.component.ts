import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { CharactersComponent } from '../characters/characters.component';
import { ShowWinnerComponent } from '../show-winner/show-winner.component';
import { WinnerService } from '../Services/winner.service';

@Component({
  selector: 'app-principal-view',
  templateUrl: './principal-view.component.html',
  styleUrls: ['./principal-view.component.css']
})
export class PrincipalViewComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    public dialog: MatDialog,
    private _winnerService: WinnerService ) { }

  ngOnInit() {
  }


  fightAndShowWinner(): void {

    let dialogRef;

    this._winnerService.getWinner().subscribe(aWinner =>{
      console.log(aWinner.winnersId);
      dialogRef = this.dialog.open(ShowWinnerComponent, {
        panelClass: "show-winner-dialog",
        //data: {winnersId : aWinner.winnersId, scoreMade : aWinner.scoreMade},
        data: {winnersId :aWinner.winnersId, scoreMade : aWinner.scoreMade},
        disableClose: true
      })

      dialogRef.afterClosed().subscribe(result => {
        console.log(`The dialog was closed-- result is ${result}`);
        if(result=="restart")
        {
          this.backToStart();
        }
      });


      });




  }





  backToStart(): void {
    this.location.back();
  }
}



//esto me esta quedando horrible para hacer un popup. recordar borrar el winner.html




export interface WinnerData {
  WinnersId: number;
  ScoreMade: number;
}

/* 

dialogRef = this.dialog.open(ShowWinnerComponent, {
  panelClass: "show-winner-dialog",
  //data: {winnersId : aWinner.winnersId, scoreMade : aWinner.scoreMade},
  data: {winnersId : 100, scoreMade : 100},
  //disableClose: true
})
 */