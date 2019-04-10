import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { WinnerData } from '../principal-view/principal-view.component';
import { WinnerResponse } from '../Models/winner-response';

@Component({
  selector: 'app-show-winner',
  templateUrl: './show-winner.component.html',
  styleUrls: ['./show-winner.component.css']
})
export class ShowWinnerComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<ShowWinnerComponent>,
    @Inject(MAT_DIALOG_DATA) public data: WinnerData) {}



  ngOnInit() {
  }
  restart():void{
    this.dialogRef.close("restart");
  }
  close():void{
    this.dialogRef.close();
  }
}
