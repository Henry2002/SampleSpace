import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { Item } from '../../models/item';
import { WebService } from '../../services/WebService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls:['./home.component.css'],
})

export class HomeComponent {

  currentItem!: Item;
  maxAtom: number;
  newMax: number

  constructor(private webService: WebService) {
    this.maxAtom = 1;
    this.newMax = 1;
    this.webService.get<Item>('item/nextItem', (result: Item) => { this.currentItem = result });
  }

  getNextItem() {
    this.webService.get<Item>('item/nextItem', (result: Item) => { this.currentItem = result; });

    

  }

  updateMaxAtom() {

    this.webService.post('item/updateMax', { value: this.newMax }, (result: string, isSuccess: boolean) => {
      if (isSuccess) {
        this.maxAtom = this.newMax;
      }
    });
  }
}
