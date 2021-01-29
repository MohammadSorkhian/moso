import {Component} from '@angular/core'

@Component({
    selector:'simple-input',
    template:`<input type='text' [(ngModel)]='userText'>
                <simple [simpleInput] = 'userText'></simple>`
})

export class SimpleInputComponent{
    userText:string = 'default'
}