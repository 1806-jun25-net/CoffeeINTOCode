import { Component, OnInit } from '@angular/core';
import { OrderClass } from './Services/order.service';
import {Order} from '../Model/Order';

//import { Hero } from '../hero';
//import { HeroService } from '../hero.service';
//import {Order} from '../Model/Order';
//import { OrderClass } from './Services/order.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  providers: [OrderClass],
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  post: Order[];
  selectedHero: Order;

  constructor(private orderService: OrderClass) { 
    
    this.orderService.getOrder().subscribe(
      (data:any[]) => {
        if(data.length)
        {
          this.post = data
          console.log(data);
          
        }
      }
    )
    
  }




  ngOnInit() {
    
  }

  // onSelect(hero: Hero): void {
  //   this.selectedHero = hero;
  // }

  // getHeroes(): void {
  //   this.heroService.getHeroes()
  //       .subscribe(heroes => this.heroes = heroes);
  // }
}
