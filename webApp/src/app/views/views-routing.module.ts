import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '',loadChildren:()=> import('./app/app.module').then(m=> m.AppModule)},
  {path: '',loadChildren:()=> import('./auth/auth.module').then(m=> m.AuthModule)},
  {path: '',loadChildren:()=> import('./error/error.module').then(m=> m.ErrorModule)},
  {path:'**',redirectTo:"/error/not-found"}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ViewsRoutingModule { }
