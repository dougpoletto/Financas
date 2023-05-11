import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-contas',
  templateUrl: './contas.component.html',
  styleUrls: ['./contas.component.css']
})
export class ContasComponent implements OnInit {
  public id: number = 0;
  public conta: Observable<Object> | undefined;

  constructor(private httpRequest: HttpClient) { }

  ngOnInit(): void {
    this.httpRequest.get(`https://localhost:5001/api/Contas/${1}`).forEach((valor) => {
      console.log(valor);
    });
  }

  public getConta(id: number): void {
  }
}

export interface Contas {
  id: number,
  numeroAgencia: string,
  numeroConta: string,
}
