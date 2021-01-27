import { from } from "rxjs";
import {Component} from '@angular/core'

@Component({
    selector: 'app-employee',
    templateUrl: './employee.component.html'

})

export class   EmployeeComponent{

firstName = 'Mohammad';
lastName = 'Sarvesabz';
gender = 'Male';
age = '34';
showDetails = false

toggleShow(){
this.showDetails = !this.showDetails
}
}