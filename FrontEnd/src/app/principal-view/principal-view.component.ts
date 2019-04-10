import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import { CharactersComponent } from '../characters/characters.component';

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
    const dialogRef = this.dialog.open(winnerComponent, {
      width: '250px',
      data: {name: "hola", animal: "this.animal"}
    });
  }
}



//esto me esta quedando horrible para hacer un popup. recordar borrar el winner.html




export interface DialogData {
  animal: string;
  name: string;
}


@Component({
  selector: 'winner',
  templateUrl: 'winner.html',
})

export class winnerComponent {

  constructor(
    public dialogRef: MatDialogRef<winnerComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) {}

  onNoClick(): void {
    this.dialogRef.close();
  }

}