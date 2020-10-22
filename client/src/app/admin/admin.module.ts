import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { MatCardModule, MatTab, MatTabGroup, MatTabsModule } from '@angular/material';
import { UserManagementComponent } from './user-management/user-management.component';
import { EmployeeManagementComponent } from './employee-management/employee-management.component';


@NgModule({
  declarations: [
    AdminPanelComponent,
    UserManagementComponent,
    EmployeeManagementComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    MatTabsModule,
    MatCardModule
  ]
})
export class AdminModule { }
