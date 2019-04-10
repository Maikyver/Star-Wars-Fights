import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharactersComponent } from './characters/characters.component';
import { PlanetsComponent } from './planets/planets.component';
import { WeaponsComponent } from './weapons/weapons.component';
import { PrincipalViewComponent, winnerComponent } from './principal-view/principal-view.component';
import { StarterComponent } from './starter/starter.component';
//import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import {MatDialogModule} from '@angular/material/dialog';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ShowWinnerComponent } from './show-winner/show-winner.component';




@NgModule({
  declarations: [
    AppComponent,
    CharactersComponent,
    PlanetsComponent,
    WeaponsComponent,
    PrincipalViewComponent,
    StarterComponent,
    ShowWinnerComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatDialogModule,
    BrowserAnimationsModule
  ],
  entryComponents: [ShowWinnerComponent],//para el popup del winner
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
