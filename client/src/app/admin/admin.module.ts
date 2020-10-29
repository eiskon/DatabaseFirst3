import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { MatButtonModule, MatCardModule, MatCheckboxModule, MatDialogModule, MatTableModule, MatTabsModule } from '@angular/material';
// import {MatCheckboxModule} from '@angular/material/checkbox';
import { UserManagementComponent } from './user-management/user-management.component';
import { EmployeeManagementComponent } from './employee-management/employee-management.component';
import { AdminService } from '../_services/admin.service';
import { RolesDialogComponent } from './roles-dialog/roles-dialog.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import {MaterialModule} from '../../app/material.module';


@NgModule({
  imports: [
    MaterialModule,
    CommonModule,
    AdminRoutingModule,
    MatTabsModule,
    MatCardModule,
    MatTableModule,
    MatButtonModule,
    FlexLayoutModule,
    MatDialogModule,
    FormsModule,
    MatCheckboxModule
  ],
  declarations: [
    AdminPanelComponent,
    UserManagementComponent,
    EmployeeManagementComponent,
    RolesDialogComponent
  ],
  entryComponents: [
    RolesDialogComponent
  ],
  providers: [
    AdminService
 ]
})
export class AdminModule { }
