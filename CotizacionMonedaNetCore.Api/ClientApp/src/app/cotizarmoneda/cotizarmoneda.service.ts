import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { observable, Observable } from 'rxjs';
import { Imoneda } from './Moneda';

@Injectable(
    {
        providedIn: 'root'
    }
)
//servicio para conectarse a la api
export class CotizarmonedaService {
    //Url con la cual se conectara a la api
    private apiUrl = this.baseUrl + "cotizacion/";
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
    //Metodo que hace el get a la api
    // recibe un parametro Tipo que es el tipo de moneda que obtendra ejempleo: cotizacion/dolar
    getMoneda(Tipo: string): Observable<Imoneda> {
        return this.http.get<Imoneda>(this.apiUrl + Tipo);
    }

}
