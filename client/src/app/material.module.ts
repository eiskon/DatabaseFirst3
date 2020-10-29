import { NgModule } from '@angular/core';
import { MdcButtonModule, MdcCheckboxModule, MdcDrawerModule, MdcFabModule, MdcFormFieldModule, 
         MdcIconModule, MdcListModule, MdcMenuModule, MdcTabBarModule } from '@angular-mdc/web';

import { MatCardModule, MatIconModule, MatToolbarModule, MatButtonModule, MatFormFieldModule,
         MatInputModule, MatTableModule, MatPaginatorModule,
         MatSelectModule, MatGridListModule, MatDialogModule, MatSortModule, 
         MatDatepickerModule, MatNativeDateModule, MatSidenavModule, MatListModule} from '@angular/material';

import { FlexLayoutModule } from '@angular/flex-layout';
import { LayoutModule } from '@angular/cdk/layout';
import { FormsModule } from '@angular/forms';


@NgModule({
  exports: [
    MdcIconModule,
    MdcIconModule,
    MdcFormFieldModule,
    MdcCheckboxModule,
    MdcTabBarModule,
    MdcFabModule,
    MdcDrawerModule,
    MdcListModule,
    MdcButtonModule,
    MdcMenuModule,

    MatFormFieldModule,
    MatCardModule,
    MatIconModule,
    MatTableModule,
    MatToolbarModule,
    MatButtonModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    FlexLayoutModule,
    MatPaginatorModule,
    LayoutModule,
    MatSidenavModule,
    MatListModule,
    FormsModule,
    MatSelectModule,
    MatGridListModule,
    MatDialogModule,
    MatSortModule
  ]
})
export class MaterialModule {}
