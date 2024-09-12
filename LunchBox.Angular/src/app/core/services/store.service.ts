import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Store } from '@core/models/store'; 
import { environment } from '@environment/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  public apiUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient) { 
  }

  getStores(): Observable<Store[]> {
    return this.httpClient.get<any[]>(`${this.apiUrl}/api/Store/stores`).pipe(
      map((stores: any[]) => 
        stores.map(store => ({
          id: store.id,
          name: store.storeName,
          address: store.street,
          logo: store.logo,
        })
      ))
    );
  }
}
