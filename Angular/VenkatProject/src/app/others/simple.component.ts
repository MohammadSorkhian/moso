import {Component, Input, OnChanges, SimpleChange, SimpleChanges} from '@angular/core'

@Component({
    selector:'simple',
    template: `<p>You entered : {{simpleInput}}</p>`
})

export class SimpleComponent implements OnChanges{
    ngOnChanges(changes: SimpleChanges) {
        for(let propertyName in changes){
            let change = changes[propertyName];
            let current = JSON.stringify(change.currentValue);
            let previous = JSON.stringify(change.previousValue);
            console.log("Previous value was " + previous + " the current value is " + current)
        }
    }
    @Input()
    simpleInput: string
}