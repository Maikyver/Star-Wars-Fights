import { Component, OnInit } from '@angular/core';
import {Planet}from './planet'
import { PlanetsService } from '../Services/planets.service';
/* import {MatSelectModule} from '@angular/material/select'; */
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-planets',
  templateUrl: './planets.component.html',
  styleUrls: ['./planets.component.css']
})
export class PlanetsComponent implements OnInit {

  planets: Response = new Response();
  selectedPlanet : string;

  constructor(private _planetsService : PlanetsService) { }
  
  setPlanet(url : string){
    this.selectedPlanet=url;
  }

  ngOnInit() {
    this.selectedPlanet = "https://swapi.co/api/planets/2/";
    this._planetsService.getPlanets()
      .subscribe(aPlanet => this.planets = aPlanet)
  }

}
