import { Component } from '@angular/core';
import { faEyeSlash, faEye } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent {
  public hidePassword: boolean = true;
  public faEyeSlash = faEyeSlash;
  public faEye = faEye;
}
