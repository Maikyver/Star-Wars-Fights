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




@NgModule({
  declarations: [
    AppComponent,
    winnerComponent,
    CharactersComponent,
    PlanetsComponent,
    WeaponsComponent,
    PrincipalViewComponent,
    StarterComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatDialogModule,
    BrowserAnimationsModule
  ],
  entryComponents: [winnerComponent],//para el popup del winner
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
