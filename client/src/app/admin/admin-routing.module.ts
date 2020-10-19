import {AdminPanelComponent} from './admin-panel/admin-panel.component';
import { AuthGuard } from '../_guards/auth.guard';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'admin',
    canActivate: [AuthGuard],
    component: AdminPanelComponent,
    data: {roles: ['Admin']} 
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
