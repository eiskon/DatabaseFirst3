import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA, MatDialogConfig, MatTableDataSource } from '@angular/material';
// import { Pagination } from 'src/app/_models/pagination';
import { User } from '../../_models/user';
import { AdminService } from '../../_services/admin.service';
import { RolesDialogComponent } from '../roles-dialog/roles-dialog.component';

@Component({
  selector: 'app-user-management',
  templateUrl: './user-management.component.html',
  styleUrls: ['./user-management.component.scss']
})
export class UserManagementComponent implements OnInit {
  users: User[];
  public dataSource: MatTableDataSource<User>;
  columnsToDisplay: string[] = [
    'id',
    'employeeId',
    'userName',
    'roles',
    'editRoles'
  ];
  // pagination: Pagination;
  availableRoles;

  constructor(private adminService: AdminService, public dialog: MatDialog) { }

  ngOnInit() {
    this.getUsersWithRoles();
    this.getAvailableRoles();
  }

  getUsersWithRoles() {
     this.adminService.getUsersWithRoles().subscribe((users: User[]) => {
      this.users = users;
      this.dataSource = new MatTableDataSource(this.users);
     }, error => {
       console.log(error);
     });
  }

  getAvailableRoles() {
    this.adminService.getAvailableRoles().subscribe((data) => {     
      this.availableRoles = data;
    }, error => {
      console.log(error);
    });
 }

   // -----------------------------------------------------------------------------------------------------
  // @ Dialog
  // -----------------------------------------------------------------------------------------------------
  openDialogEditUserRoles(user: User) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = false;
    dialogConfig.autoFocus = true;
    dialogConfig.direction = 'rtl';
    const dialogRef = this.dialog.open(RolesDialogComponent, {
      width: '1000px',
      disableClose: false,
      position: { top: '1%' },
      maxHeight: '96vh',
      panelClass: ['mat-dialog-overflow', 'dialog-0-p']
    }); 
    dialogRef.componentInstance.user = user;
    dialogRef.componentInstance.roles = this.getRolesArray(user);
  }

  private getRolesArray(user):any[] {
    const roles = [];
    const userRoles = user.roles;
    
    for (let i = 0; i < this.availableRoles.length; i++) {
      let isMatch = false;
      for (let j = 0; j < userRoles.length; j++) {
        if (this.availableRoles[i].name === userRoles[j]) {
          isMatch = true;
          this.availableRoles[i].checked = true;
          roles.push(this.availableRoles[i]);
          break;
        }
      }
      if (!isMatch) {
        this.availableRoles[i].checked = false;
        roles.push(this.availableRoles[i]);
      }
    }
    return roles;
  }
}
