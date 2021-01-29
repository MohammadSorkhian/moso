import {Component, Input, Output, EventEmitter} from '@angular/core'

@Component({
    selector: 'employee-count',
    templateUrl: './employeeCount.component.html'
})


export class EmployeeCountComponent{

    selectedRadioButtonValue = 'All';

    @Output()
    countRadioButtonSelectionChange = new EventEmitter<string>();

    @Input()
    all;

    @Input()
    male;

    @Input()
    female;

    onRadioButonSelectionChange(){
        this.countRadioButtonSelectionChange.emit(this.selectedRadioButtonValue);
    }
}