import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PrincipalViewComponent } from './principal-view/principal-view.component';
import {StarterComponent} from './starter/starter.component'
const routes: Routes = [
  { path: '', redirectTo: 'app-starter', pathMatch: 'full' },
  { path: 'app-starter', component: StarterComponent },
  { path: 'principal-view', component: PrincipalViewComponent },
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
