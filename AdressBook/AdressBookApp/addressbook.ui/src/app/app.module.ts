import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { AppAddressbookListComponent } from './app-addressbook-list/app-addressbook-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AppAddressbookAddComponent } from './app-addressbook-add/app-addressbook-add.component';
import { MatIconModule } from "@angular/material/icon";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { MatTooltipModule } from "@angular/material/tooltip";
import { MatCheckboxModule } from "@angular/material/checkbox";
import { MatTableModule } from "@angular/material/table";
import { MatSortModule } from "@angular/material/sort";
import { MatDialogModule } from "@angular/material/dialog";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatButtonModule } from "@angular/material/button";
import { ScrollingModule } from "@angular/cdk/scrolling";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatExpansionModule } from "@angular/material/expansion";
import { MatSnackBar } from "@angular/material/snack-bar";
import {MatCardModule} from '@angular/material/card'; 
import { MatSlideToggleModule } from "@angular/material/slide-toggle";
import { MatButtonToggleModule } from "@angular/material/button-toggle";
import { MatTabsModule } from "@angular/material/tabs";
import { MatMenuModule } from "@angular/material/menu";
import { MatDividerModule } from "@angular/material/divider";
import { MatRadioModule } from "@angular/material/radio";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AppAddressbookListComponent,
    AppAddressbookAddComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    NoopAnimationsModule,
    HttpClientModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
    MatCheckboxModule,
    MatTableModule,
    MatSortModule,
    MatDialogModule,
    MatFormFieldModule,
    MatButtonModule,
    ScrollingModule,
    MatSidenavModule,
    MatExpansionModule,
    MatSlideToggleModule,
    MatButtonToggleModule,
    MatMenuModule,
    MatTabsModule,
    MatDividerModule,
    MatRadioModule,
    MatDatepickerModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
