import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'
import { AppComponent } from './app.component';
import {EmployeeComponent} from './employee/employee.component';
import {EmployeeList} from './employee/employeeList.component'
import {EmployeeTitlePipe} from './employee/employeeTitle.pipe'
import {EmployeeCountComponent} from './employee/employeeCount.component'

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    EmployeeList,
    EmployeeTitlePipe,
    EmployeeCountComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
