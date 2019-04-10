import { Component, OnInit } from '@angular/core';
import {Planet}from './planet'
import { PlanetsService } from '../Services/planets.service';
/* import {MatSelectModule} from '@angular/material/select'; */

@Component({
  selector: 'app-planets',
  templateUrl: './planets.component.html',
  styleUrls: ['./planets.component.css']
})
export class PlanetsComponent implements OnInit {

  planet: Response = new Response();

  constructor(private _planetsService : PlanetsService) { }
  

  ngOnInit() {
    this._planetsService.getPlanets()
      .subscribe(aPlanet => this.planet = aPlanet)
  }

}
