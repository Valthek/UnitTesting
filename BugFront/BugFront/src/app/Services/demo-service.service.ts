import { Injectable } from '@angular/core';

export interface IDemoService {
  increment(): any;
  decrement(): any;
}

@Injectable({
  providedIn: 'root',
})
export class DemoService implements IDemoService {
  value = 0;
  message!: string;

  increment() {
    if (this.value < 15) {
      this.value += 1;
      this.message = '';
    } else {
      this.message = 'Maximum reached!';
    }
  }

  decrement() {
    if (this.value > 0) {
      this.value -= 1;
      this.message = '';
    } else {
      this.message = 'Minimum reached!';
    }
  }
}
