import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-contas',
  templateUrl: './contas.component.html',
  styleUrls: ['./contas.component.scss']
})
export class ContasComponent implements OnInit {
  public id: number = 0;
  public conta: Observable<Object> | undefined;

  constructor(private httpRequest: HttpClient) { }

  ngOnInit(): void {

  }

  public getConta(id: number): void {
    this.httpRequest.get(`https://localhost:5001/api/Contas/${1}`).forEach((valor) => {
      console.log(valor);
    });
  }
}

export interface Contas {
  id: number,
  numeroAgencia: string,
  numeroConta: string,
}
