import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CotizarmonedaService } from './cotizarmoneda.service';
import { Imoneda } from './Moneda';
import { Router, NavigationEnd } from '@angular/router';

@Component({
    selector: 'app-cotizarmoneda',
    templateUrl: './cotizarmoneda.component.html',
    styleUrls: ['./cotizarmoneda.component.css']
})

export class Cotizarmoneda implements OnInit {
    //variables al cual se le asigna la interfaz para llenar los datos
    Dolar: Imoneda;
    Euro: Imoneda;
    Real: Imoneda;
    refrescarcomp = true;
    Numerorandom: any;

    ngOnInit(): void {
        this.Obtenerdata();
    }

    constructor(private router: Router, private monedaService: CotizarmonedaService) {
    }

    public Obtenerdata() {
        this.getDolar('dolar');
        this.getEuro('euro');
        this.getReal('real');
        this.refrescar();
        this.refrescarcomp = true;
    }

    //metodos encargado de obtener los datos por medio del services
    public getDolar(tipo: string) {
        this.monedaService.getMoneda(tipo)
            .subscribe(moneda => this.Dolar = moneda,
                error => console.error(error));
    }
    public getEuro(tipo: string) {
        this.monedaService.getMoneda(tipo)
            .subscribe(moneda => this.Euro = moneda,
                error => console.error(error));
    }
    public getReal(tipo: string) {
        this.monedaService.getMoneda(tipo)
            .subscribe(moneda => this.Real = moneda,
                error => console.error(error));
    }

    //Metodo encargado de refrescar el componente
    public refrescar() {
        setTimeout(() => {
            console.log('Refrescando pagina');
            this.refrescarcomp = false;
            this.ngOnInit();
        }, 5000);
    }
}

