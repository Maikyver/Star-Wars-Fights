import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import { CharactersComponent } from '../characters/characters.component';
import { ShowWinnerComponent } from '../show-winner/show-winner.component';

@Component({
  selector: 'app-principal-view',
  templateUrl: './principal-view.component.html',
  styleUrls: ['./principal-view.component.css']
})
export class PrincipalViewComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    public dialog: MatDialog) {}

  ngOnInit() {
  }


  fightAndShowWinner():void{
    const dialogRef = this.dialog.open(ShowWinnerComponent, {
      panelClass : "show-winner-dialog",
      data: {name: "hola", animal: "UnAnimal"},
      disableClose: true
    });
    //dialogRef.
  }
  backToStart():void{
    this.location.back();
  }
}



//esto me esta quedando horrible para hacer un popup. recordar borrar el winner.html




export interface WinnerData {
  animal: string;
  name: string;
}
