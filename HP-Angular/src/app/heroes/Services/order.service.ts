import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class OrderClass {
    constructor(private http: Http){
        console.log("Order");
    }

    getOrder(){
        return this.http.get('http://localhost:5001/api/Order/GetOrders')
       .map(res => res.json());
           
        
        
    }
}