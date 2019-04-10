import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { WinnerData } from '../principal-view/principal-view.component';

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
  onNoClick(): void {
    //this.dialogRef.close();  
  }
  close():void{
    this.dialogRef.close();
  }
}
