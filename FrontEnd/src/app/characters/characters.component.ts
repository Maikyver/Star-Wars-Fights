import { Component, OnInit } from '@angular/core';
import { Character_Response } from './character';
import { CharactersService } from '../Services/characters.service';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.css']
})
export class CharactersComponent implements OnInit {
  characters : Character_Response = new Character_Response();

  constructor(private _charactersService : CharactersService) { }

  ngOnInit() {
    this._charactersService.getCharacters()
      .subscribe(characters => this.characters = characters)
  }

}
