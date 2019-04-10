import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Character_Response } from '../characters/character';

@Injectable({
  providedIn: 'root'
})
export class CharactersService {
  private _url="/api/character/characters/6";

  constructor(private http: HttpClient) { }
  getCharacters() : Observable<Character_Response>{

    return this.http.get<Character_Response>(this._url)
  }
}
