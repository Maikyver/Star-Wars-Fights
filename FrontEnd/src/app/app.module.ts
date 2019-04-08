import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharactersComponent } from './characters/characters.component';
import { PlanetsComponent } from './planets/planets.component';
import { WeaponsComponent } from './weapons/weapons.component';
import { PrincipalViewComponent } from './principal-view/principal-view.component';
import { StarterComponent } from './starter/starter.component';


@NgModule({
  declarations: [
    AppComponent,
    CharactersComponent,
    PlanetsComponent,
    WeaponsComponent,
    PrincipalViewComponent,
    StarterComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
